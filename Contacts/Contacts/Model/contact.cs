using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Contacts.Model
{
    public class contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }


    }

    //public class contact
    //{

    //public event PropertyChangedEventHandler PropertyChanged;
    //public int _Id;
    //public string _FirstName;
    //public string _LastName;
    //public int _Phone;
    //public string _Email;
    //public bool _IsBlocked;
    //public int Id
    //{
    //    get
    //    {
    //        return _Id;
    //    }
    //    set
    //    {
    //        if (_Id == value)
    //            return;
    //        Id = value;
    //        //  onpropertychnaged();
    //    }


    //}
    //public string FirstName
    //{
    //    get
    //    {
    //        return _FirstName;
    //    }
    //    set
    //    {
    //        if (_FirstName == value)
    //            return;
    //        _FirstName = value;
    //        // onpropertychnaged();
    //    }


    //}
    //public string LastName
    //{
    //    get
    //    {
    //        return _LastName;
    //    }
    //    set
    //    {
    //        if (_LastName == value)
    //            return;
    //        _LastName = value;
    //        // onpropertychnaged();
    //    }


    //}
    //public int Phone
    //{
    //    get
    //    {
    //        return _Phone;
    //    }
    //    set
    //    {
    //        if (_Phone == value)
    //            return;
    //        _Phone = value;
    //        //  onpropertychnaged();
    //    }


    //}
    //public string Email
    //{
    //    get
    //    {
    //        return _Email;
    //    }
    //    set
    //    {
    //        if (_Email == value)
    //            return;
    //        _Email = value;
    //        // onpropertychnaged();
    //    }


    //}
    //public bool IsBlocked
    //{
    //    get
    //    {
    //        return _IsBlocked;
    //    }
    //    set
    //    {
    //        if (_IsBlocked == value)
    //            return;
    //        _IsBlocked = value;
    //        // onpropertychnaged();
    //    }


    //}


    //public void onpropertychnaged([CallerMemberName]string propertyName = null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}
//}
    }
