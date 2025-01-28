using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username=="" && File.Exists(filePath)) 
                { 
                     File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#"+Password ;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);
                   
                  return true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath  = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }

        }
    
        public static bool ShowPasswordAndChangeIcon(ref Guna.UI2.WinForms.Guna2TextBox textBox,ref PictureBox pictureBox)
        {
            if (textBox.PasswordChar == '*')
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
                textBox.PasswordChar = '*';
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
                    NewEmail += '*';
            }

            return NewEmail;
        }
    
        public static bool CheckIfTwoTextsAreMatched(string FirstText,string SecText)
        {
            return FirstText == SecText && FirstText.Length > 0;
        }

        public static bool HandelChooseImageFromFileExplorer(ref OpenFileDialog openFileDialog,
                                                             ref Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog.FileName;
                pictureBox.Load(selectedFilePath);
                // ...

                return true;
            }

            return false;
        }
    }
}

