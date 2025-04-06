using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Drawing.Image;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SendGrid;
using SendGrid.Helpers.Mail;
using clsBussinessLayer;
using System.Net;

namespace Hospital_Management_System.Classes
{
    internal static  class clsGlobal
    {
        public static clsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Hospital Management System";

            try
            {
                // concatonate username and passwrod withe seperator.

                //Save data to Registry
                Registry.SetValue(keyPath, "Username", Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", Password, RegistryValueKind.String);

                return true;
                
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Hospital Management System";
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
               string valueData1 = Registry.GetValue(keyPath, "Username", null) as string;
               string valueData2 = Registry.GetValue(keyPath, "Password", null) as string;

                if(valueData1 != null && valueData2 != null)
                {

                    Username = valueData1;
                    Password = valueData2;

                }
                else
                {
                    MessageBox.Show($"No value found with name Username And Password");
                }

                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }

        }
    
        public static bool ShowPasswordAndChangeIcon(ref Guna.UI2.WinForms.Guna2TextBox textBox,ref PictureBox pictureBox)
        {
            if (textBox.PasswordChar == '•')
            {
                textBox.PasswordChar = '\0';
                if (pictureBox.ImageLocation == "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png")
                {
                    pictureBox.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\HideEye_Password.png";
                    return true;
                }
            }

            return false;
        }

        public static bool HidePasswordAndChangeIcon(ref Guna.UI2.WinForms.Guna2TextBox textBox,ref PictureBox pictureBox)
        {
            if (textBox.PasswordChar == '\0' && textBox.Text != "Enter your password")
            {
                textBox.PasswordChar = '•';
                if(pictureBox.ImageLocation == "C:\\Users\\Hassan\\Pictures\\Icnos\\HideEye_Password.png")
                {
                    pictureBox.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";
                    return true;
                }
            }

            return false;
        }

        //public static string SendCodeToAnEmail(string TargetEmail, string Username)
        //{
        //    //return Global.EmailSender.SendCodeToAnEmail(TargetEmail, Username).ToString();
        //}

        public static string GetARandomNumber()
        {
            Random random = new Random();
            string code = random.Next(100000, 999999).ToString();

            return code;
        }

        public static string ReFormatEmail( string Email)
        {
            string NewEmail = "";

            for(int i = 0; i < Email.Length;i++)
            {
                if (i < 3)
                {
                    NewEmail += Email[i];
                }

                else if (Email[i] == '@')
                {
                    for (int j = i - 2; j < Email.Length; j++)
                    {
                        
                        NewEmail += Email[j];
                    }
                    break;
                }
                else
                    NewEmail += '•';
            }

            return NewEmail;
        }
    
        public static bool CheckIfTwoTextsAreMatched(string FirstText,string SecText)
        {
            return FirstText == SecText && FirstText.Length > 0;
        }

        public static bool HandelChooseImageFromFileExplorer(ref System.Windows.Forms.OpenFileDialog openFileDialog,
                                                             ref Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox, ref string ImagePath)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog.FileName;
                ImagePath = selectedFilePath;
                pictureBox.Image = FromFile(selectedFilePath); 
                // ...

                return true;
            }

            return false;
        }
    }
}

