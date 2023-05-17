using System;
using SharedElements.Models;
using SharedElements.Helpers;


public class Employee
{
    public int? Id { get; private set; }
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public string PESEL { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public bool IsActive { get; private set; }
    public Role AssignedRole { get; private set; }
    public List<Specialization?> ListOfSpecialization { get; private set; }
    public string? CorrespondenceAddress { get; private set; }
    public string? EmailAddress { get; private set; }
    public string? PhoneNumber { get; private set; }
    public char? Sex { get; private set; }


    public Employee(int? id, string firstName, string lastName, string pesel, DateTime dateOfBirth, bool isActive, Role role, List<Specialization?> specialization = null, string? correspondenceAddress = null, string? emailAddress = null, string? phoneNumber = null, char? sex = null)
	{
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        //if (!EmployeeHelper.IsPeselCorrect(pesel))
        //{
        //    throw new Exception("PESEL is incorrect!");
        //}
        PESEL = pesel;
        //if (!EmployeeHelper.IsDateOfBirthCorrect(dateOfBirth))
        //{
        //    throw new Exception("Date of birth is incorrect!");
        //}
        DateOfBirth = dateOfBirth;
        IsActive = isActive;
        AssignedRole = role;
        ListOfSpecialization = specialization;
        CorrespondenceAddress = correspondenceAddress;
        //if (emailAddress is not null)
        //{
        //    if (!EmployeeHelper.IsEmailAddressCorrect(emailAddress, firstName, lastName))
        //    {
        //        throw new Exception("Email address is incorrect!");
        //    }
        //}
        EmailAddress = emailAddress;
        //if (phoneNumber is not null)
        //{
        //    if (!EmployeeHelper.IsPhoneNumberCorrect(phoneNumber))
        //    {
        //        throw new Exception("Email address is incorrect!");
        //    }
        //}
        PhoneNumber = phoneNumber;
        Sex = sex;
    }
    public void AddSpecializationToEmployee(Specialization specialization) {
        ListOfSpecialization.Add(specialization);
    }
    public override string ToString() 
    {
        return "Employee_nr: "+Id+", "+FirstName + " " + LastName;
    }
}
