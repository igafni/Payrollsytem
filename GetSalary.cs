using System;
using System.Collections.Generic;
using System.Text;


namespace PayrollSytem
{
    class GetSalary
    {
        //select box = []
        public string _ErorSalary { get; set; }
        public GetSalary(int id, string fullname, string monthame = null)
        {
            _ErorSalary = "";
            Id = id;
            FullName = fullname;
            MonthName = monthame;
            ReadJsonData jsonData = new ReadJsonData(Id, FullName);
            if (jsonData._Eror == "")
            {
                EmployeeWorkTime employeeWorkTimeObject = jsonData.ReadMainJsonData();
                Role = employeeWorkTimeObject.Role;
                Department = employeeWorkTimeObject.Department;
            }
            else
            {
                _ErorSalary = jsonData._Eror;
            }
        }
        public int Id { get; }
        public string FullName { get; }
        public string MonthName { get; }
        public string Role { get; }
        public string Department { get; }

        public string PrintManagementDepartmentSalaryReport()
        {

            switch (Role)
            {
                case "עוזר שף":
                    AssistantChef AssistantObject = new AssistantChef(Id, FullName);
                    return AssistantObject.PaySalary(MonthName);
                case "שף":
                    Chef ChefObject = new Chef(Id, FullName);
                    return ChefObject.PaySalary(MonthName);
                case "מנקה":
                    Cleaner CleanerObject = new Cleaner(Id, FullName);
                    return CleanerObject.PaySalary(MonthName);
                case "אחמש מנקים":
                    CleanerAhmash CleanerAhmashObject = new CleanerAhmash(Id, FullName);
                    return CleanerAhmashObject.PaySalary(MonthName);
                case "טבח":
                    Cook CookObject = new Cook(Id, FullName);
                    return CookObject.PaySalary(MonthName);
                case "מחלק מזון":
                    FoodEmployee FoodEmployeeObject = new FoodEmployee(Id, FullName);
                    return FoodEmployeeObject.PaySalary(MonthName);
                case "ראש מחלקת הנהלה":
                    HeadOfAdministration HeadOfAdministrationObject = new HeadOfAdministration(Id, FullName);
                    return HeadOfAdministrationObject.PaySalary(MonthName);
                case "רב מנקים":
                    SeniorCleaner SeniorCleanerObject = new SeniorCleaner(Id, FullName);
                    return SeniorCleanerObject.PaySalary(MonthName);
                case "מנקה חומרים רעילים":
                    ToxicCleaner ToxicCleanerObject = new ToxicCleaner(Id, FullName);
                    return ToxicCleanerObject.PaySalary(MonthName);
            }
            return "Employee not found in the system";
        }


        public string PrintProfessionalDepartmentSalaryReport()
        {
            switch (Role)
            {
                case "רופא סטאזר ומיילד לידת עכוז":
                    BreechAndIntershipDoctor BreechAndIntershipDoctorObject = new BreechAndIntershipDoctor(Id, FullName);
                    return BreechAndIntershipDoctorObject.PaySalary(MonthName);
                case "מיילדת לידת עכוז":
                    BreechMidwife BreechMidwifeObject = new BreechMidwife(Id, FullName);
                    return BreechMidwifeObject.PaySalary(MonthName);
                case "ס. מנהל מחלקה":
                    DeputyHeadOfDepartment DeputyHeadOfDepartmentObject = new DeputyHeadOfDepartment(Id, FullName);
                    return DeputyHeadOfDepartmentObject.PaySalary(MonthName);
                case "רופא":
                    Doctor DoctorObject = new Doctor(Id, FullName);
                    return DoctorObject.PaySalary(MonthName);
                case "אחות ראשית":
                    HeadNurse HeadNurseObject = new HeadNurse(Id, FullName);
                    return HeadNurseObject.PaySalary(MonthName);
                case "רופא סטאזר":
                    InternshipDoctor InternshipDoctorObject = new InternshipDoctor(Id, FullName);
                    return InternshipDoctorObject.PaySalary(MonthName);
                case "חובש":
                    Medic MedicObject = new Medic(Id, FullName);
                    return MedicObject.PaySalary(MonthName);
                case "מיילדת":
                    MidWife MidWifeObject = new MidWife(Id, FullName);
                    return MidWifeObject.PaySalary(MonthName);
                case "אחות":
                    Nurse NurseObject = new Nurse(Id, FullName);
                    return NurseObject.PaySalary(MonthName);
                case "פארמדיק":
                    Paramedic ParamedicObject = new Paramedic(Id, FullName);
                    return ParamedicObject.PaySalary(MonthName);
                case "מנהל מחלקה":
                    Paramedic ProfessionalDepartmentManager = new Paramedic(Id, FullName);
                    return ProfessionalDepartmentManager.PaySalary(MonthName);
                case "רופא בכיר":
                    SeniorDoctor SeniorDoctorObject = new SeniorDoctor(Id, FullName);
                    return SeniorDoctorObject.PaySalary(MonthName);
                case "רופא מומחה":
                    SpecializedDoctor SpecializedDoctorObject = new SpecializedDoctor(Id, FullName);
                    return SpecializedDoctorObject.PaySalary(MonthName);
            }
            return "Employee not found in the system";
        }
    }
}
