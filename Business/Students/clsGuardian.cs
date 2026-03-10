using Business.Persons;
using DataAccess.Students;
using GlobalLayer;
using Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Students
{
    public class clsGuardian
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int GuardianID { get; set; }
        public int PersonID { get; set; }
        public string Jobs { get; set; }
        public string Notes { get; set; }
        public clsPerson PeronInfo;

        public clsGuardian()
        {
            this.GuardianID = -1;
            this.PersonID = -1;
            this.Jobs = string.Empty;
            this.Notes = string.Empty;
            this.Mode = enMode.AddNew;
            this.PeronInfo = null;
        }

        public clsGuardian(GuardianDTO dto, enMode mode = enMode.Update)
        {
            this.GuardianID = dto.GuardianID;
            this.PersonID = dto.PersonID;
            this.Jobs = dto.Jobs;
            this.Notes = dto.Notes;
            this.Mode = mode;
            this.PeronInfo = clsPerson.Find(PersonID);
        }

        private bool AddPersonGuardian()
        {
            // تحقق منطق إضافي قبل الإرسال لـ DAL
            if (string.IsNullOrWhiteSpace(this.PeronInfo.FirstName) || string.IsNullOrWhiteSpace(this.PeronInfo.LastName))
                throw new ArgumentException("الاسم الأول واللقب مطلوبان.");

            // Create an instance of clsGuardianData to call the non-static method
            var guardianData = new clsGuardianData();
            var result = guardianData.InsertPersonGuardian(
                this.PeronInfo.FirstName, this.PeronInfo.LastName,
                this.PeronInfo.ThirdName, this.PeronInfo.LastName,
                this.PeronInfo.IdentifierID, this.PeronInfo.Gender,
                this.PeronInfo.BirthDate, this.PeronInfo.Phone,
                this.PeronInfo.Email, this.PeronInfo.Address,
                this.PeronInfo.ImagePath, this.Jobs, this.Notes);
            GuardianID = result.NewGuardianID;
            PersonID = result.NewPersonID;
            return result.NewPersonID != -1 && result.NewGuardianID != -1;

        }

        private bool _AddNew()
        {
            if (clsGuardianData.DoesPersonHaveGuardian(PersonID))
            {
                Console.WriteLine("Guardian already exists for this PersonID.");
                return false;
            }
            if (clsGuardianData.IsPersonLinkedToGuardian(PersonID))
            {
                return false;
            }

            GuardianID = clsGuardianData.InsertGuardian(PersonID, Jobs, Notes);
            return GuardianID != -1;
        }

        private bool _Update()
        {
            if (!clsGuardianData.DoesPersonHaveGuardian(GuardianID))
            {
                Console.WriteLine("Guardian does not exist.");
                return false;
            }
            if (clsGuardianData.IsPersonLinkedToGuardian(PersonID))
            {
                return false;
            }

            return clsGuardianData.UpdateGuardian(GuardianID, PersonID, Jobs, Notes);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew() || AddPersonGuardian())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _Update();
                default:
                    return false;
            }
        }

        public static bool Delete(int guardianID)
        {
            return clsGuardianData.DeleteGuardian(guardianID);
        }

        public static clsGuardian Find(int guardianID)
        {
            var dto = clsGuardianData.GetGuardianByID(guardianID);
            if (dto == null) return null;
            return new clsGuardian(dto, enMode.Update);
        }

        public static List<GuardianDTO> GetAll()
        {
            return clsGuardianData.GetAllGuardians();
        }

        public static List<GuardianDTO> GetByPersonID(int personID)
        {
            return clsGuardianData.GetGuardiansByPersonID(personID);
        }

        public static bool Exists(int personID)
        {
            return clsGuardianData.DoesPersonHaveGuardian(personID);
        }
    }

}
