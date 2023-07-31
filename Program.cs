using Hospital.UI;
using hospital_3.DL;
using Hospital.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.BL;

namespace Hospital
{
    static class Program
    {
        private static readonly Form previousForm;
        internal static int Value;
        private static List<Patient> patients;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SignUpInDataLayer.readData("SignUpIn_Data.txt");
            PatientDataLayer.ReadFromFile("Patient_Data.txt");
            DoctorDataLayer.ReadFromFile("Doctor_Data.txt");
            MedicineDataLayer.ReadFromFile("Medicine_Data.txt");
            HospitalDataLayer.ReadFromFile("Ward_Data.txt,out hospitals");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageHospitalWards(previousForm));
            SignUpFORM signUp = new SignUpFORM();
            Application.Run(signUp);

            if (Welcome1.CurrentUserRole == "Admin")
            {
                HomeAdmin homeAdmin = new HomeAdmin();
                Application.Run(homeAdmin);
            }
            else
            {
                HomeUser homeUser = new HomeUser();
                Application.Run(homeUser);
            }

        }
    }
}
