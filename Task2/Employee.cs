public class Employee{
    int id ;
    string firstName;
    string lastName;
    int salary;

    public Employee (int id,string firstName,string lastName,int salary)
    {
     this.id = id;
       this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

public int getID() {
    return id;
}
public string getFirstName(){
    return firstName;
}
public string getLastName(){
    return lastName;
}
public string getName()
{
    return $"{firstName} {lastName}";
}
public int getSalary(){
    return salary;
} 
public void SetSalary(int salary){
    this.salary=salary;
}
public int getAnnualSalary()
{
return salary*12;
}
public int  raiseSalary (int percent){
salary = salary * (100 + percent) / 100;
         return salary;
}
public override string ToString()
    {
        return $"Employee {id}, name = {firstName} {lastName}, {salary}";
    }
}