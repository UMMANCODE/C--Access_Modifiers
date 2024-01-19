namespace ClassLibrary1 {
    public abstract class City {
        protected string _name;
        protected int _population;

        public string Name {
            get {
                return _name;
            }
            set {
                if (CheckName(value)) _name = value;
            }
        }

        public virtual int Population {
            get {
                return _population;
            }
            set {
                if (value >= 0) _population = value;
            }
        }

        private bool CheckName(string value) {
            bool isNameValid = true;
            for (int i = 0; i < value.Length; i++) {
                if (!char.IsLetter(value[i])) {
                    isNameValid = false;
                }
            }
            if (value.Length < 3 || value.Length > 20)
                isNameValid = false;
            return isNameValid;
        }

    }
}
