
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeview
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTreeLoad_Click(object sender, EventArgs e)
        {
            //폴더 경로 , 어떤 트리에다 넣을 건지 

            TreeViewLoadByPath(tviewLocation, tboxSource.Text);


        }

        private void TreeViewLoadByPath(TreeView treeView, string path )
        {
            if (!string.IsNullOrEmpty(path) )
            {

                DirectoryInfo rootDirectoryInfo = new DirectoryInfo(path);
                //TreeNode TN = new TreeNode();
                treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
            }
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }


            return directoryNode;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            //tviewLocation.ExpandAll();
            if (tviewLocation.SelectedNode != null)
            {
                tviewLocation.SelectedNode.ExpandAll();
            }
           
        }

        private void btnCoolapse_Click(object sender, EventArgs e)
        {
            tviewLocation.CollapseAll();
        }

        private void tviewLocation_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tviewLocation_DoubleClick(object sender, EventArgs e)
        {
            string strSelectPath = tviewLocation.SelectedNode.FullPath;
            lboxCommand.Items.Add(strSelectPath);
        }
        //폴더 보여주기
        private void lboxCommand_Click(object sender, EventArgs e)
        {
            if (lboxCommand.SelectedIndex != -1)
            {
                string path = tboxSource.Text; // 앞쪽경로
                string LastPath = Path.GetDirectoryName(path);
                string strPath = lboxCommand.SelectedItem.ToString();

                string dirPath = $@"{LastPath}\{strPath}";

                StringBuilder sb = new StringBuilder();

                if (Directory.Exists(dirPath))
                {
                    DirectoryInfo di = new DirectoryInfo(dirPath);
                    foreach (var directory in di.GetDirectories())
                    {
                        sb.Append($"[Folder] { directory} \r\n");
                    }
                    
                    foreach (var file in di.GetFiles())
                    {
                        sb.Append($"{file.Name} \r\n");
                    }
                    tboxFile.Text = sb.ToString();
                }
            }
        }


        //삭제
        private void lboxCommand_DoubleClick(object sender, EventArgs e)
        {
            if (lboxCommand.SelectedIndex != -1)
            {
                lboxCommand.Items.RemoveAt(lboxCommand.SelectedIndex);
            }
            

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxDestination.Text))
            {

                string sourcePath = SourcePath(); //source file

                string destinationPath = $@"{tboxDestination.Text}\{DateTime.Now:yyyyMMdd.hhss}";
                Log(enLoglevel.Info, $"Source: {sourcePath}");
                Log(enLoglevel.Info, $"Destination: {destinationPath}");

                FileSystem.CopyDirectory(sourcePath, destinationPath, UIOption.AllDialogs);
                Log(enLoglevel.Info, $"경로 백업을 완료 하였습니다.");

            }
        }

        // log
        enum enLoglevel
        {
            Info,
            Warning,
            Error,
        }
        private void Log(enLoglevel eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;
            lboxLog.Items.Insert(0,dTime + eLevel.ToString() + LogDesc);

        }
        private void Log(DateTime dTime, enLoglevel eLevel, string LogDesc)
        {
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        private string SourcePath()
        {
            if (String.IsNullOrEmpty(tboxSource.Text))
            {
                Log(enLoglevel.Warning, "Source 경로가 입력되어 있지 않습니다.");
                return null;
            }
            string path = tboxSource.Text; // 앞쪽경로
            string LastPath = Path.GetDirectoryName(path);
            string strPath = lboxCommand.SelectedItem.ToString();

            string dirPath = $@"{LastPath}\{strPath}";

            return dirPath;

        }

    }
}
