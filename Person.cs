namespace TestCsharpWinFormDesktopLearning6
{
    public class Person
    {
        private int _businessEntityID = 0;
        private string _personType = string.Empty;
        private int _nameStyle = 0;
        private string _title = string.Empty;
        private string _firstName = string.Empty;
        private string _middleName = string.Empty;
        private string _lastName = string.Empty;
        private string _suffix = string.Empty;
        private int _emailPromotion = 0;
        private string _additionalContactInfo = string.Empty;
        private string _demographics = string.Empty;
        private Guid _rowguid;
        private DateTime _modifiedDate_AE;

        //Properties
        public int BusinessEntityID
        {
            get { return _businessEntityID; }
            set { _businessEntityID = value; }
        }

        public string PersonType
        {
            get { return _personType; }
            set { _personType = value; }
        }

        public int NameStyle
        {
            get { return _nameStyle; }
            set { _nameStyle = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Suffix
        {
            get { return _suffix; }
            set { _suffix = value; }
        }

        public int EmailPromotion
        {
            get { return _emailPromotion; }
            set { _emailPromotion = value; }

        }

        public string AdditionalContactInfo
        {
            get { return _additionalContactInfo; }
            set { _additionalContactInfo = value; }

        }

        public string Demographics
        {
            get { return _demographics; }
            set { _demographics = value; }
        }

        public Guid Rowguid
        {
            get { return _rowguid; }
            set { _rowguid = value; }

        }

        public DateTime ModifiedDate_AE
        {
            get { return _modifiedDate_AE; }
            set { _modifiedDate_AE = value; }
        }

        public string FullNameInfo
        {
            get { return $"{FirstName} {MiddleName} {LastName} {Suffix}  {Title} "; }
        }
    }
}
