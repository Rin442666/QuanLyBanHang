using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BTL1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.SetData("BaseDirectory", AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", ""));

            string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\QLBH.mdf;Integrated Security=True";

            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            string[] triggerFiles =
            {
                Path.Combine(baseDir, "Trigger_HH.sql"),
                Path.Combine(baseDir, "Trigger_HDB.sql"),
                Path.Combine(baseDir, "Trigger_CTHDN.sql"),
                Path.Combine(baseDir, "Trigger_CTHDB.sql")
            };

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (string triggerFile in triggerFiles)
                    {
                        if (!File.Exists(triggerFile))
                        {
                            Console.WriteLine($"⚠️ Không tìm thấy file: {Path.GetFileName(triggerFile)}");
                            continue;
                        }

                        string script = File.ReadAllText(triggerFile);

                        // Cắt theo "GO" (phòng trường hợp trong file có nhiều batch)
                        string[] commands = script.Split(
                            new[] { "GO", "go", "Go", "gO" },
                            StringSplitOptions.RemoveEmptyEntries
                        );

                        foreach (string commandText in commands)
                        {
                            string trimmed = commandText.Trim();
                            if (string.IsNullOrWhiteSpace(trimmed)) continue;

                            using (SqlCommand cmd = new SqlCommand(trimmed, conn))
                            {
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    Console.WriteLine($"✅ Đã chạy trigger: {Path.GetFileName(triggerFile)}");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"❌ Lỗi khi chạy trigger {Path.GetFileName(triggerFile)}:\n👉 {ex.Message}\n");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thiết lập trigger trong cơ sở dữ liệu:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new Main());
        }
    }
}
