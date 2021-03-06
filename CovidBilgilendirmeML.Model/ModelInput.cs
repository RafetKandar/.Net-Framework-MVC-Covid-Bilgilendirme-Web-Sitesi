// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace CovidBilgilendirmeML.Model
{
    public class ModelInput
    {
        [ColumnName("HealthWorker"), LoadColumn(0)]
        public string HealthWorker { get; set; }


        [ColumnName("MedicalCenter"), LoadColumn(1)]
        public string MedicalCenter { get; set; }


        [ColumnName("Touch"), LoadColumn(2)]
        public string Touch { get; set; }


        [ColumnName("Fever"), LoadColumn(3)]
        public string Fever { get; set; }


        [ColumnName("ChronicLung"), LoadColumn(4)]
        public string ChronicLung { get; set; }


        [ColumnName("Diabetes"), LoadColumn(5)]
        public string Diabetes { get; set; }


        [ColumnName("Hypertension"), LoadColumn(6)]
        public string Hypertension { get; set; }


        [ColumnName("ChronicLiver"), LoadColumn(7)]
        public string ChronicLiver { get; set; }


        [ColumnName("Chemotheraphy"), LoadColumn(8)]
        public string Chemotheraphy { get; set; }


        [ColumnName("FeverHour"), LoadColumn(9)]
        public string FeverHour { get; set; }


        [ColumnName("ShortnesOfBreath"), LoadColumn(10)]
        public string ShortnesOfBreath { get; set; }


        [ColumnName("Sorethrout"), LoadColumn(11)]
        public string Sorethrout { get; set; }


        [ColumnName("RunnyNose"), LoadColumn(12)]
        public string RunnyNose { get; set; }


        [ColumnName("Diearrhea"), LoadColumn(13)]
        public string Diearrhea { get; set; }


        [ColumnName("Class"), LoadColumn(14)]
        public string Class { get; set; }


    }
}
