﻿namespace Sahlgrenska.app.classes
{
    public class Patient
    {
        public string Name;
        public Patient(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}