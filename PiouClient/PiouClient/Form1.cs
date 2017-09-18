using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiouClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
FileAssociationInfo fai = new FileAssociationInfo(".piou");
    if (!fai.Exists)
      {
         fai.Create("Piou");

         //Specify MIME type (optional)
         fai.ContentType = "script/PiouClient.Script";

         //Programs automatically displayed in open with list
         fai.OpenWithList = new string[]
        { "notepad.exe", "wordpad.exe", "PiouClient.exe" };
       }
    ProgramAssociationInfo pai = new ProgramAssociationInfo(fai.ProgID);
    if (!pai.Exists)
      {
         pai.Create
         (
         //Description of program/file type
         "PIOUScript"

         new ProgramVerb
              (
              //Verb name
              "Open",
              //Path and arguments to use
              @"C:\piou\PiouClient\PiouClient\bin\debug\PiouClient.exe %1"
              )
            );

         //optional
         pai.DefaultIcon = new ProgramIcon(@"C:\PiouClient\twiiter-bird.ico")
       }
