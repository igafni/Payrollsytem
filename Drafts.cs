/*
string t = "24/06/2021 20:12";
string t2 = "24/06/2021 22:11";
string t3 = "25/06/2021 06:44";
string t4 = "25/06/2021 09:12";
string t5 = "28/07/2021 08:12";
string t6 = "28/07/2021 09:55";
string monthName = "July";
//Console.WriteLine(DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture).Month.ToString());
//Console.WriteLine((o2 -o).TotalHours);
int id = 32229733;
string fullname = "Itay Gafni";
string dateofbirth = "21/04/2000";
string department = "Professional";
string role = "Manager";
Employee e = new Employee(id, fullname, dateofbirth, department, role);
AddEmployee k = new AddEmployee(id, fullname, dateofbirth, department, role);
AddEmployeeWorkTime w = new AddEmployeeWorkTime(id, fullname, t, t2);
AddEmployeeWorkTime w2 = new AddEmployeeWorkTime(id, fullname, t3, t4);
AddEmployeeWorkTime w3 = new AddEmployeeWorkTime(id, fullname, t5, t6);
ToxicCleaner f = new ToxicCleaner(id, fullname);
f.PaySalary("July");
//ProfessionalDepartment.ProfessionalDepartmentManager p = new ProfessionalDepartment.ProfessionalDepartmentManager(id, fullname);
//p.PaySalary();
//Console.WriteLine(o.Hour-o2.Hour);
//DateTime o = DateTime.ParseExact(i, "dd/MM/yyyy HH:mm tt",null);
//EmployeeWorkTime m = new EmployeeWorkTime(12345, "Itay Gafni", "21/04/1998", "M", "M", t, t2);
//m.AddWorkTime(t3, t4);
//m.AddWorkTime(t5, t6);
//Console.WriteLine(m.WorkHours);
//string fileName = "1234.json";
//string jsonString = JsonSerializer.Serialize(m);
//Console.WriteLine(jsonString);
//File.WriteAllText(fileName, jsonString);
//Employee s = new Employee(12, "Itay Gafni", "21 / 04 / 1998", "MM", "MM");
//s.CreateFirstJsonFile(s);
/*
ReadJsonData r = new ReadJsonData(12, "Itay Gafni");
Employee emp = r.ReadFirstJsonData();
EmployeeWorkTime n = new EmployeeWorkTime(12, "Itay Gafni", emp.DateOfBirth.ToString(), "MM", "MM",null);
n.AddWorkTime(t, t2);
n.CreateWorkJson(n);
string jsonString = File.ReadAllText(r.FileName);
//Console.WriteLine(jsonString);
EmployeeWorkTime employeeJsonData = JsonConvert.DeserializeObject<EmployeeWorkTime>(jsonString);
//Console.WriteLine(employeeJsonData.WorkHours.GetType());
var b = r.GetAllMonthWorkTime("6", employeeJsonData.WorkHours);
foreach (var work in b)
{
    foreach (var keyValue in work)
    {
        Console.WriteLine(keyValue.Value);
    }
}


Console.WriteLine(b);
//EmployeeWorkTime d = r.ReadMainJsonData();
//Console.WriteLine(d);
*
AddEmployee a = new AddEmployee(id, fullname, dateofbirth, department, role);
AddEmployeeWorkTime w = new AddEmployeeWorkTime(id, fullname, t5, t6);
var l = w._jsondata.GetAllMonthWorkTime(DateTime.Now.Month.ToString(),w._employeeWork.WorkHours);
string jsonString = File.ReadAllText(w._jsondata.FileName);
Console.WriteLine(jsonString);
w._jsondata.PrintAllWorkHours(w._jsondata.ReadMainJsonData().WorkHours);
if (l==null)
{
    Console.WriteLine("No monthly salary found in the System");
}
else
{
    foreach (var work in l)
    {
        foreach (var keyValue in work)
        {
            Console.WriteLine(keyValue.Key);
            Console.WriteLine(keyValue.Value);
        }
    }
}
*/