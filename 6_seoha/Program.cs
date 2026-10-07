using System;
class Seoha
{
    public string Name = "서하";
    public string Birthday = "2136.07.02";
    public string Gender = "여성";

    public void Abstract()
    {
        Console.WriteLine(Name + "가 여백경을 사용합니다.");
    }

    public void ShootBow()
    {
        Console.WriteLine(Name + "가 성좌궁을 하늘에 쏩니다.");
    }

    public void Slash()
    {
        Console.WriteLine(Name + "가 화염검을 사용합니다.");
    }
}

class MainClass
{
    public static void Main (string[] args)
    {
        Seoha seoha = new Seoha();
        seoha.Name = "김서하";
        seoha.Abstract();
        seoha.ShootBow();
        seoha.Slash();
    } 
}


// 더 현대적인 스타일
class Seoha2
{
    public string Name = "서하";
    public string Birthday = "2136.07.02";
    public string Gender = "여성";

    public void UseYeobaekgyeong()
    {
        Console.WriteLine($"{Name}가 여백경을 사용합니다.");
    }

    public void ShootBow()
    {
        Console.WriteLine($"{Name}가 성좌궁을 하늘에 쏩니다.");
    }

    public void Slash()
    {
        Console.WriteLine($"{Name}가 화염검을 사용합니다.");
    }
}