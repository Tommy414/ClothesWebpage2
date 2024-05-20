﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection



    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create test data to assign to the property
            //This time it is a list
            List<clsStaff> TestList = new List<clsStaff>();
            //Add Item to the list
            clsStaff TestItem = new clsStaff();
            //Set the properties
            TestItem.StaffId = 2;
            TestItem.FullTime = true;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //Add the items to the list
            TestList.Add(TestItem);
            //Assign data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

  

        [TestMethod]
        public void ThisStaffProperty()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff StaffTest = new clsStaff();
            //Set properties of test object
            StaffTest.StaffId = 2;
            StaffTest.FullTime = true;
            StaffTest.Name = "JohnHayes";
            StaffTest.Hours = "21";
            StaffTest.PhoneNumber = "07894447379";
            StaffTest.DateAdded = DateTime.Now;
            StaffTest.Email = "p2774538@my365.dmuac.uk";
            //assign the data
            AllStaff.ThisStaff = StaffTest;
            Assert.AreEqual(AllStaff.ThisStaff, StaffTest);
        }

        [TestMethod]
        public void ListAndCount()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the test data
            clsStaff TestItem = new clsStaff();
            //Set the properties
            TestItem.StaffId = 2;
            TestItem.FullTime = true;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //Add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }



    }
}