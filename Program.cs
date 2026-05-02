double a, b, c;

    Console.WriteLine(" Salom Siz Arifmetik amallarni bajaruvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
        Console.Write("Birinchi qiymatni kiriting : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi qiymatni kiriting : ");
        b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 📐 To‘g‘ri burchakli uchburchak gipotenuzasi va yuzini berilgan qiymatlar asosida topamiz !\n Siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Gipotenuza: ");
            c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            Console.Write(c +"\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida uchburchakning gipotenuzasi : " + c);
            Console.WriteLine("Yuzasi : " + (a*b)/2);


Console.WriteLine(" Salom Siz Parallel ulangan ikki qarshilikning umumiy qarshiligi topuvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
        Console.Write("Birinchi qarshilikning qiymatni kiriting : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi qarshilikning qiymatni kiriting : ");
        b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 🔌 Parallel ulangan ikki qarshilikning umumiy qarshiligi berilgan qiymatlar asosida topamiz !\n Dastur siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Umumiy qarshilik : ");
            c = ((a * b)/(a + b));
            Console.Write(c +"\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida parallel ulangan ikki qarshilikning umumiy qarshiligi : " + c);
                       

Console.WriteLine(" Salom Siz 📊 Geometrik va arifmetik o‘rtacha qiymatlar qiymatlarni aniqlovchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
        Console.Write("Birinchi qiymatni kiriting : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi qiymatni kiriting : ");
        b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("📊 Geometrik va Arifmetik o‘rtacha qiymat berilgan qiymatlar asosida topamiz !\n Siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Arifmetik o‘rtacha qiymat: ");
            c = (a+b)/2;
            Console.Write(c +"\n");
            Console.Write("Geometrik o‘rtacha qiymat: ");
            double d = Math.Sqrt(a*b);
            Console.Write(d +"\n");
            

Console.WriteLine(" Salom Siz 💰 Protsent farqi (o‘zgarish foizi)ni topuvchi dasturni ishga tushurdingiz !\n Shu sababli siz 2 ta qiymat kiritishingiz kerak bo'ladi !");
        Console.Write("Boshlang'ich qiymatni kiriting : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Oxirgi yani Yakuniy qiymatni kiriting : ");
        b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. 💰 Protsent farqi (o‘zgarish foizi) berilgan qiymatlar asosida topamiz !\n Dastur siz kiritgan ,malumotlar asosida bajarilmoqda !");
            Console.Write("Protsent farqi : ");
            c = ((b-a)/a*100);
            Console.Write(c +"%\n");
            Console.WriteLine("Yani siz kiritgan qiymatlar asosida 💰 Protsent farqi (o‘zgarish foizi) : " + c);
                
