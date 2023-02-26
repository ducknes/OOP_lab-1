using System;

namespace lab_1
{
    class Bank
    {
        private string _bankName;
        private ulong _numberOfContributions;
        private double _interestRate;
        private uint _numberOfClients;
        private bool _workingNow;
        private byte _numberOfFilials;
        private char _bankRating;
        private short _numberOfCredits;

        public Bank(){
            _bankName = "";
            _numberOfContributions = 0;
            _interestRate = 0d;
            _numberOfClients = 0;
            _workingNow = false;
            _numberOfFilials = 0;
            _bankRating = '-';
            _numberOfCredits = 0;
        }

        public Bank(string bankName){
            this._bankName = bankName;
        }

        public Bank(string bankName, bool workingNow) {
            this._bankName = bankName;
            this._workingNow = workingNow;
        }

        public Bank(string bankName, ulong numberOfContributions, double interestRate, uint numberOfClients, bool workingNow,
            byte numberOfFilials, char bankRating, short numberOfCredits) {
            this._bankName = bankName;
            this._numberOfContributions = numberOfContributions;
            this._interestRate = interestRate;
            this._numberOfClients = numberOfClients;
            this._workingNow = workingNow;
            this._numberOfFilials = numberOfFilials;
            this._bankRating = bankRating;
            this._numberOfCredits = numberOfCredits;
        }

        public string BankName {
            get => this._bankName;
            set => this._bankName = value;
        }

        public ulong NumberOfContributions {
            get => this._numberOfContributions;
            set => this._numberOfContributions = value;
        }

        public double InterestRate {
            get => this._interestRate;
            set => this._interestRate = value;
        }

        public uint NumberOfClients {
            get => this._numberOfClients;
            set => this._numberOfClients = value;
        }

        public bool WorkingNow{
            get => this._workingNow;
            set => this._workingNow = value;
        }

        public byte NumberOfFilials {
            get => this._numberOfFilials;
            set => this._numberOfFilials = value;
        }

        public char BankRating {
            get => this._bankRating;
            set => this._bankRating = value;
        }

        public short NumberOfCredits {
            get => this._numberOfCredits;
            set => this._numberOfCredits = value;
        }

        public override string ToString()
        {
            return "Банк: " + this._bankName + "\n" + "Число вкладов: " + this._numberOfContributions + "\n" + "Размер процентной ставки: " +
                this._interestRate + "\n" + "Количество клиентов: " + this._numberOfClients + "\n" + "Сейчас работает: " + this._workingNow + "\n" +
                "Число филиалов: " + this._numberOfFilials + "\n" + "Рейтинг банка: " + this._bankRating + "\n" + "Количество кредитов: " +
                this._numberOfCredits;
        }

         public void PrintField(){
             Console.WriteLine("Выберите поле которое хотите просмотреть: \n " +
                 "1) Название банка \n " +
                 "2) Число вкладов \n " +
                 "3) Размер процентной ставки \n " +
                 "4) Количество клиентов \n " +
                 "5) Работает ли сейчас \n " +
                 "6) Число филиалов \n " +
                 "7) Рейтинг банка \n " +
                 "8) Количество кредитов");
             int fieldIndex = Convert.ToInt32(Console.ReadLine());
             switch (fieldIndex)
             {
                 case 1:
                     Console.WriteLine($"Название банка: {this._bankName}");
                     break;
                 case 2:
                     Console.WriteLine($"Число вкладов: {this._numberOfContributions}");
                     break;
                 case 3:
                     Console.WriteLine($"Размер процентной ставки: {this._interestRate}");
                     break;
                 case 4:
                     Console.WriteLine($"Количество клиентов: {this._numberOfClients}");
                     break;
                 case 5:
                     Console.WriteLine($"Работает ли сейчас: {this._workingNow}");
                     break;
                 case 6:
                     Console.WriteLine($"Число филиалов: {this._numberOfFilials}");
                     break;
                 case 7:
                     Console.WriteLine($"Рейтинг банка: {this._bankRating}");
                     break;
                 case 8:
                     Console.WriteLine($"Количество кредитов: {this._numberOfCredits}");
                     break;
             }
         }
    }
}