﻿namespace Assignment.ConsoleApp.Interfaces;

public interface IContactMenuService
{
    void ShowAllContacts();
    void AddNewContact();
    void ShowOneContact(string input);
    void UpdateContact(string input);
    void DeleteContact(string input);
}