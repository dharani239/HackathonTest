using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworksApp
{
    class Disease
    {
        public string DiseaseName { get; set; }
        public string DiseaseSeverity { get; set; }
        public string Cause { get; set; }
        public string DiseaseDescription { get; set; }
    }

    class Symptom : Disease
    {
       
        public string SymptomName { get; set; }
        public string Description { get; set; }
        //enum diseases { Malaria, dengue, Diarrhea, Kalara };
        //public static void ChooseDisease()
        //{
        //    Console.WriteLine("Enter the Disease :");
        //    Array PossibleDiseases = Enum.GetValues(typeof(diseases));
        //    for (int i = 0; i < PossibleDiseases.Length; i++)
        //    {
        //        Console.WriteLine(PossibleDiseases.GetValue(i));
        //    }
        //    string DiseaseType = Console.ReadLine();
        //} 
        public static void DisplayDetails(Array[] _diseases)
        {
            Console.WriteLine("Disease details as follows");
            foreach (var disease in _diseases)
            {
                Console.WriteLine(disease);
            }
        }

        
    }   
    
        
    
    class DiseaseDetails
    {
        internal static Disease[] _diseases = null;
        private int _size = 0; 
        public DiseaseDetails(int size)
        {
            _size = size;
            _diseases = new Disease[size];
        } 
        public static void addDiseaseDetails(Disease disease)
        {
            for(int i=0;i<_diseases.Length;i++)
            {
                if(_diseases[i]==null)
                {
                    _diseases[i] = new Disease { DiseaseName = disease.DiseaseName, DiseaseDescription = disease.DiseaseDescription, DiseaseSeverity = disease.DiseaseSeverity, Cause = disease.Cause };
                    return;
                }
            }
            
        } 
       

        

    } 
    class UIMedical
    {
        public static DiseaseDetails dis = null;

        internal static void DisplayDetails(string file)
        {
            int size = Utilities.GetNumber("Enter size");
            dis = new DiseaseDetails(size);
            bool processing = true;
            string menu = File.ReadAllText(file);
            do
            {
                int choice = Utilities.GetNumber(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for using our application");
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingDiseaseHelper();
                    break;
                case 2:
                    addingSymptomHelper();
                    break;
                case 3:
                    checkPatientHelper();

                default:
                    return false;
            }
            return true;
        }
        private static void addingDiseaseHelper()
        {
            string disease = Utilities.prompt("Enter the Disease name");
            string severity = Utilities.prompt("Enter the severity of the disease");
            string cause = Utilities.prompt("Enter cause of the disease");
            string description = Utilities.prompt("Enter the Description of the Disease");
            Disease diseas = new Disease {DiseaseName=disease,DiseaseSeverity=severity,Cause=cause,DiseaseDescription=description};
            DiseaseDetails.addDiseaseDetails(diseas);
            Utilities.prompt("Press Enter to clear the Screen");
            Console.Clear();
        }
        private static void addingSymptomHelper()
        {

        }
        private static void checkPatientHelper()
        {

        }

    }
    class Patient
    {
        public string PatientName { get; set; }
        public string SymptomName { get; set; }
    } 
    class PatientDetails
    {

        string name = Utilities.prompt("Enter Name of the Patient");
        string symptomName = Utilities.prompt("Enter Symptom Name");
       
    }
    class MedicalHealthApp
    {
        static void Main(string[] args)
        {
            UIMedical.DisplayDetails(args[0]);
        }
    }
}
