using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReplaceProtoFile
{
    public partial class Form1 : Form
    {
        string mSaveTxtPath;
        public Form1()
        {
            InitializeComponent();
            mSaveTxtPath = Path.Combine(Application.StartupPath, "zProtoReplace.txt");
        }

        string txtOriOutPath = @"D:\WorkProject\UnityClient\Proto\out\cs";

        void SaveTxtPath()
        {
            string contentTxt = this.txtServerPath.Text + "*" + this.txtProtoPath.Text + "*" + this.txtUnityProtoPath.Text;
            File.WriteAllText(mSaveTxtPath, contentTxt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(mSaveTxtPath))
            {
                string txtContent = File.ReadAllText(mSaveTxtPath);

                var strs = txtContent.Split('*');
                this.txtServerPath.Text = strs[0];
                this.txtProtoPath.Text = strs[1];
                this.txtUnityProtoPath.Text = strs[2];
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveTxtPath();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            lblExcInfo.Text = "等待 2";
            var path = txtProtoPath.Text;
            string[] directories = Directory.GetDirectories(path);

            foreach (string dir in directories)
            {
                string[] protoFiles = Directory.GetFiles(dir, "*.proto");           // 搜索每个子文件夹下的所有*.proto文件
                foreach (string file in protoFiles)
                {
                    //等待100毫秒，防止文件操作过快
                    Task.Delay(100).Wait();
                    //得到 文件名
                    string fileName = Path.GetFileName(file);

                    if (fileName.Contains("GamePacketIDs") || fileName.Contains("HallPacketIDs"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package Pb;";
                        lines[2] = @"option csharp_namespace = ""Pb"";";

                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("GameSystem"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package Pb;";
                        lines[2] = @"option csharp_namespace = ""Pb"";";
                        lines[3] = @"import ""common/GamePacketIDs.proto"";";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("common") || fileName.Contains("Common"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package pb;";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("GameBattle.proto"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package Pb;";
                        lines[2] = @"import ""common/Common.proto"";";
                        lines[3] = @"import ""common/GamePacketIDs.proto"";";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("HallAccount.proto"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package Pb;";
                        lines[2] = @"import ""hall/HallPacketIDs.proto"";";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("GameLogin.proto"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package pb;";
                        lines[2] = @"import ""common/GamePacketIDs.proto"";";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                    else if (fileName.Contains("GamePlayerInfo.proto"))
                    {
                        string[] lines = File.ReadAllLines(file);
                        // 替换
                        lines[0] = @"syntax = ""proto2"";";
                        lines[1] = @"package pb;";
                        lines[2] = @"import ""common/Common.proto"";";
                        lines[3] = @"import ""common/GamePacketIDs.proto"";";
                        File.WriteAllLines(file, lines); // 将修改后的内容写回文件
                    }
                }
            }

            lblExcInfo.Text = "完成 2";
            SaveTxtPath();
        }

        private void btnUnityReplaceFile_Click(object sender, EventArgs e)
        {
            var pathOld = txtUnityProtoPath.Text; //@"D:\WorkProject\UnityClient\Unity\Assets\Hotfix\CodeGen\Proto";
            var pathNew = this.txtProtoPath.Text.Replace(@"\protofiles\protofile\client", @"\out\cs"); //@"D:\WorkProject\UnityClient\Proto\out\cs";

            var fileNames = new List<string>() { "GamePlayerInfo.cs", "GameBattle.cs", "common.cs", "GamePacketIDs.cs", "GameSystem.cs", "HallPacketIDs.cs", "HallAccount.cs", "GameLogin.cs" };

            foreach (var fileName in fileNames)
            {
                ReplaceFiles(pathNew, pathOld, fileName);
            }

            lblExcInfo.Text = "完成 4";
        }

        public static void ReplaceFiles(string pathNew, string pathOld, string fileName)
        {
            // 递归查找并替换文件
            ReplaceFilesRecursive(pathNew, pathOld, fileName);
        }

        private static void ReplaceFilesRecursive(string pathNew, string pathOld, string fileName)
        {
            // 查找pathNew目录及其子目录下的fileName文件
            var sourceFiles = Directory.GetFiles(pathNew, fileName, SearchOption.AllDirectories);
            foreach (var sourceFile in sourceFiles)
            {
                // 获取相对路径
                var relativePath = sourceFile.Substring(pathNew.Length).TrimStart(Path.DirectorySeparatorChar);

                // 构建pathOld目录下的目标文件路径
                var destinationFile = Path.Combine(pathOld, relativePath);

                // 确保目标文件所在的目录存在
                var destinationDirectory = Path.GetDirectoryName(destinationFile);
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                // 替换文件
                File.Copy(sourceFile, destinationFile, true);
            }
        }

        private async void btnReplaceTxt_Click(object sender, EventArgs e)
        {
            lblExcInfo.Text = "等待 5";
            var pathUnity = txtUnityProtoPath.Text; //@"D:\WorkProject\UnityClient\Unity\Assets\Hotfix\CodeGen\Proto";
            ModifyMemberAuth(pathUnity);

            await Task.Delay(1000);
            //1秒后 再执行  别休眠
            ModifyOther(pathUnity);

            lblExcInfo.Text = "完成 5  去Unity搞事情吧~";
        }
        static void ModifyOther(string path)
        {
            string[] files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
            var strOld = @"[global::ProtoBuf.ProtoMember(2, Name = @""points"")]
        public global::System.Collections.Generic.List<PointInfo> Points { get; } = new global::System.Collections.Generic.List<PointInfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @""bmove"")]
        public global::System.Collections.Generic.List<BuildMove> Bmoves { get; } = new global::System.Collections.Generic.List<BuildMove>();";

            var strNew = @"[global::ProtoBuf.ProtoMember(2, Name = @""points"")]
        public global::System.Collections.Generic.List<PointInfo> Points { get; set;} = new global::System.Collections.Generic.List<PointInfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @""bmove"")]
        public global::System.Collections.Generic.List<BuildMove> Bmoves { get; set;} = new global::System.Collections.Generic.List<BuildMove>();";

            //替换下 字符串
            foreach (string file in files)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(strOld))
                {
                    content = content.Replace(strOld, strNew);
                    File.WriteAllText(file, content);
                }
            }
        }

        static void ModifyMemberAuth(string path)
        {
            string[] files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories);
            foreach (string filePath in files)
            {
                try
                {
                    // 读取原始文件内容
                    string fileContent = File.ReadAllText(filePath);
                    string searchString = "public global::System.Collections.Generic.List";
                    string classSearchStr = "public partial class";
                    string containStr = "Opcodes.CgMsg";
                    fileContent = UpdateMemberAuth(fileContent, searchString, classSearchStr, containStr, out bool result);
                    if (result)
                    {
                        File.WriteAllText(filePath, fileContent);
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("文件未找到。");
                }
                catch (IOException e)
                {
                    MessageBox.Show($"文件操作时发生错误: {e.Message}");
                }
            }
        }

        static string UpdateMemberAuth(string str, string searchString, string startString, string containStr, out bool result)
        {
            result = false;
            int index = 0;
            while ((index = str.IndexOf(searchString, index, StringComparison.Ordinal)) != -1)
            {
                int startIndex = str.LastIndexOf(startString, index, StringComparison.Ordinal);
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                string classStr = str.Substring(startIndex, index - startIndex);
                if (classStr.Contains(containStr))
                {
                    //需要操作
                    int endIndex = str.IndexOf(");", index, StringComparison.Ordinal);
                    string leftStr = str.Substring(0, index);
                    string middleStr = str.Substring(index, endIndex - index).Replace(" { get; }", "");
                    string rightStr = str.Substring(endIndex, str.Length - endIndex);

                    str = leftStr + middleStr + rightStr;
                    result = true;
                }
                index += searchString.Length;
            }

            return str;
        }

        private void btnSVN_Click(object sender, EventArgs e)
        {
            // 设置源文件夹和目标文件夹
            string sourceDir = txtServerPath.Text;//@"D:\WorkProject\Common\Common_Simulation\Common\NetProto\Source";
            string destDir = txtProtoPath.Text; //@"D:\WorkProject\UnityClient\Proto\protofiles\protofile\client";

            // 更新SVN
            UpdateSvnDirectory(sourceDir);
            UpdateSvnDirectory(destDir);

            // 遍历源文件夹内的文件
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                var fileName = Path.GetFileName(file);

                // 遍历目标文件夹内的所有子文件夹
                foreach (var dir in Directory.GetDirectories(destDir, "*", SearchOption.AllDirectories))
                {
                    var targetFile = Path.Combine(dir, fileName);

                    if (File.Exists(targetFile))
                    {
                        // 存在同名文件，进行复制并重命名为原名_New
                        var newFileName = Path.GetFileNameWithoutExtension(fileName) + "_New" + Path.GetExtension(fileName);
                        var newFilePath = Path.Combine(dir, newFileName);
                        File.Copy(file, newFilePath, true);

                        // 删除旧文件
                        File.Delete(targetFile);

                        // 将新文件重命名为原名
                        File.Move(newFilePath, targetFile);
                    }
                }
            }

            lblExcInfo.Text = "完成 1";
        }

        private void UpdateSvnDirectory(string dir)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "svn.exe",
                    Arguments = $"update \"{dir}\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"SVN更新错误: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblExcInfo.Text = "等待 3";

            // 设置源目录
            string directory = this.txtProtoPath.Text.Replace(@"\protofiles\protofile\client", ""); // @"D:\WorkProject\UnityClient\Proto";
            string pbToolPath = System.IO.Path.Combine(directory, "PbTool", "pbtool.exe");

            // 创建一个新的进程启动信息
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = pbToolPath,
                Arguments = "-type=csharp_pbnet",
                WorkingDirectory = directory, // 设置工作目录
                UseShellExecute = false, // 如果需要获取输出内容需要设置为false
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            try
            {
                // 启动进程
                using (Process process = Process.Start(startInfo))
                {
                    // 等待进程结束
                    process.WaitForExit();

                    // 获取输出信息
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // 显示结果
                    lblExcInfo.Text = "完成 3";
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "错误信息");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }


    }
}