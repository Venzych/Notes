Console.WriteLine(Narcissistic(153));
bool Narcissistic(int value)
{
    var str = value.ToString();
    return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
}
