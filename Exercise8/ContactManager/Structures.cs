namespace ContactManager
{
    struct Contact
    {
        private string _firstName;
        private string _lastName;
        private int _phoneNo;
        private Address _address;
        private Gender _gender;

        public Contact(string firstName, string lastName, int phoneNo, Address address, Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNo = phoneNo;
            _address = address;
            _gender = gender;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int PhoneNo { get => _phoneNo; set => _phoneNo = value; }
        internal Address Address { get => _address; set => _address = value; }
        internal Gender Gender { get => _gender; set => _gender = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Address}";
        }
    }

    struct Address
    {
        private string _city;
        private string _street;
        private int _houseNo;

        public string City { get => _city; set => _city = value; }
        public string Street { get => _street; set => _street = value; }
        public int HouseNo { get => _houseNo; set => _houseNo = value; }

        public override string ToString()
        {
            return $"{City} {Street}";
        }
    }

    enum Gender
    {
        MALE,
        FEMALE
    }
}