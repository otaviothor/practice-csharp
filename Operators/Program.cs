// conversao implicita
// o C# entende essa operacao e o valor de y vai ser 100.00
// int x = 100;
// double y = x;

// aqui vai dar erro porque o C# nao entende o que fazer com as casas decimais 100.00
// double x = 100.50;
// int y = x;

// teriamos que forcar a operacao usando o (int), nesse caso ele vai descartar os decimais

// double x = 100.50;
// int y = (int) x;

// var phone = new Phone
// {
//   CountryCode = "55",
//   Area = "11",
//   Number = "999999999"
// };
// var newPhone = "123";
// newPhone = phone;
// Console.WriteLine(newPhone);

var phone = new Phone();
phone = "55 11 999999999";
Console.WriteLine(phone);

public class Phone // System => ToString
{
  public string CountryCode { get; set; }
  public string Area { get; set; }
  public string Number { get; set; }

  public static implicit operator string(Phone phone)
    => $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

  public static implicit operator Phone(string phone)
  {
    var data = phone.Split(" ");
    return new Phone
    {
      CountryCode = data[0],
      Area = data[1],
      Number = data[2]
    };
  }

  // public override string ToString()
  // {
  //   return $"+{CountryCode} ({Area}) {Number}";
  // }
}