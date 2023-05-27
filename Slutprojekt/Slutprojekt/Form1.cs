using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GroupBoxSettings.Visible = false;
            InfoTextsVisibleFalse();
            RunProgram.Enabled = false;
            GroupBoxDone.Visible = false;
        }

        public void Settings_Click(object sender, EventArgs e)
        {
            if (GroupBoxSettings.Visible == false)
            {
                GroupBoxSettings.Visible = true;
            }
            else
            {
                GroupBoxSettings.Visible = false;
            }
        }
        public void InfoTextsVisibleFalse()
        {
            LabelSortByYear.Visible = false;
            LabelSortByMonth.Visible = false;
            LabelSortByDay.Visible = false;
        }
        public void InfoIcon_Click(object sender, EventArgs e)
        {
            if (LabelSortByYear.Visible == true)
            {
                LabelSortByYear.Visible = false;
                LabelSortByMonth.Visible = false;
                LabelSortByDay.Visible = false;
            }
            else
            {
                LabelSortByYear.Visible = true;
                LabelSortByMonth.Visible = true;
                LabelSortByDay.Visible = true;
            }
        }
        public static DateTime? DateTaken(Image getImage)
        {
            int DateTakenValue = 0x9003; //36867;
            //if no value exists close filestream and return date as 9999-12-31
            if (!getImage.PropertyIdList.Contains(DateTakenValue))
            {
                getImage.Dispose();
                return new DateTime(9999,12,31);
            }
            //Separates values as year, month, day ...
            string dateTakenTag = Encoding.ASCII.GetString(getImage.GetPropertyItem(DateTakenValue).Value);
            string[] parts = dateTakenTag.Split(':', ' ');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);
            int hour = int.Parse(parts[3]);
            int minute = int.Parse(parts[4]);
            int second = int.Parse(parts[5]);
            getImage.Dispose();//closes filesteam 
            return new DateTime(year, month, day, hour, minute, second); //Returns all values 
        }
        public void FolderBrowserDialogSortMethod()
        {
            FolderBrowserDialog FolderBrowserDialogSort = new FolderBrowserDialog();
            FolderBrowserDialogSort.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = FolderBrowserDialogSort.ShowDialog();
            if (result == DialogResult.OK)
            {
                ButtonSortFile.Text = FolderBrowserDialogSort.SelectedPath;
                //Makes the buttons text full filepath that is selected

            }
        }
            public void CreateDirectory()
        {
            var FolderBrowserDialogExtract = ButtonExtractFile.Text;
            //Rootfolder
            var FolderBrowserDialogSort = ButtonSortFile.Text;
            //Destination
            List<string> Images = System.IO.Directory.GetFiles(FolderBrowserDialogExtract, "*.*", System.IO.SearchOption.AllDirectories).ToList(); 
            //Takes every image from rootfolder and adds to the list 
            int TotalImages = Images.Count;
            int FailedImages = 0;
            LabelTotalImages.Text = "Total image: " + TotalImages.ToString(); //Total images in list
            foreach (string image in Images)
            {
                    DateTime PictureDate = (DateTime)DateTaken(Image.FromFile(image));
                    if (PictureDate == new DateTime(9999, 12, 31)) //If image has no date
                    {
                        FailedImages++; //Add to total errors
                        LabelFailedImages.Text = "Amount of errors " + FailedImages.ToString();
                        continue; //Go to next image in list
                    }
                    string SubFolderYear = System.IO.Path.Combine(FolderBrowserDialogSort.ToString(), PictureDate.Year.ToString());
                    string SubFolderMonth = System.IO.Path.Combine(SubFolderYear, PictureDate.Month.ToString());
                    string ImageWithPathMonth = System.IO.Path.Combine(SubFolderMonth, System.IO.Path.GetFileName(image));
                    string SubFolderDay = System.IO.Path.Combine(SubFolderMonth, PictureDate.Day.ToString());
                    string ImageWithPathDay = System.IO.Path.Combine(SubFolderDay, System.IO.Path.GetFileName(image));
                    //Makes vars from every instance of image
                    System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(FolderBrowserDialogSort.ToString());
                    System.IO.FileInfo mFile = new System.IO.FileInfo(image);
                        //Sorts the image from different conditions
                        if (!System.IO.Directory.Exists(SubFolderYear)) 
                        {
                            System.IO.Directory.CreateDirectory(SubFolderYear);
                            if (!System.IO.Directory.Exists(SubFolderMonth))
                            {
                                System.IO.Directory.CreateDirectory(SubFolderMonth);
                                if((!System.IO.Directory.Exists(SubFolderDay))&& (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.Directory.CreateDirectory(SubFolderDay);
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if ((System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if (CheckBoxSortByDay.Checked == false)
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathMonth);
                                }
                            }
                            else
                            {
                                if ((!System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.Directory.CreateDirectory(SubFolderDay);
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if ((System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if (CheckBoxSortByDay.Checked == false)
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathMonth);
                                }
                            }
                        }
                        else
                        {
                            if (!System.IO.Directory.Exists(SubFolderMonth))
                            {
                                System.IO.Directory.CreateDirectory(SubFolderMonth);
                                if ((!System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.Directory.CreateDirectory(SubFolderDay);
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if ((System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if (CheckBoxSortByDay.Checked == false)
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathMonth);
                                }
                            }
                            else
                            {
                                if ((!System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.Directory.CreateDirectory(SubFolderDay);
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if ((System.IO.Directory.Exists(SubFolderDay)) && (CheckBoxSortByDay.Checked == true))
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathDay);
                                }
                                else if (CheckBoxSortByDay.Checked == false)
                                {
                                    System.IO.File.Move(mFile.ToString(), ImageWithPathMonth);
                                    
                                }
                            }
                        }
                
            }
            
        }
        public void ButtonSortFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogSortMethod();
        }
        private void ButtonExtractFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialogExtract = new FolderBrowserDialog();
            FolderBrowserDialogExtract.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = FolderBrowserDialogExtract.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                ButtonExtractFile.Text = FolderBrowserDialogExtract.SelectedPath; //Makes the buttons text full filepath that is selected
                RunProgram.Enabled = true;
            }
        }
        private void RunProgram_Click(object sender, EventArgs e)
        {
            CreateDirectory();
            GroupBoxDone.Visible = true;
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            GroupBoxDone.Visible = false;
        }
    }
}
