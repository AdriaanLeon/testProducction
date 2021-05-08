using System;

namespace partOne.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Titular { get; set; }
        public double Quantity { get; set; }

        public Account(){}
        public string ShowDataAccount()
        {
            return $"{this.Titular} {this.Quantity}";
        }
        public string InputQuantity (int quatity){
            this.Quantity = quatity;
            if(this.Quantity < 0 ){
                return "this quantity is not correct";
            }else{
                return "Quantity is added correcty";
            }
        }
        public string ExtraerQuantity (int quantity){
            var result = this.Quantity - quantity;
            this.Quantity = result;
            if (result <= 0){
                return "Money insuficient or you cannot let are in zero";
            }else {
                return "Successful";
            }
        }
    }
}