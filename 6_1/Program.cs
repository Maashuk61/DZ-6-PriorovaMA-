// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

bool inpValid_01(int num)
{
    if(num > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool inpValid(string num)
{
    bool res_val = int.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

int intUserNum = 0;
string strUserNum = "";
int sumRes = 0;
while(true)
{
    Console.WriteLine("Введите число или слово 'stop': ");
    strUserNum = Console.ReadLine();
    if(strUserNum.ToLower() == "stop")
    {
        Console.WriteLine($"Всего чисел больше нуля: {sumRes}");
        break;
    }
    else
    {
        bool result = inpValid(strUserNum);
        if(result == true)
        {
            intUserNum = Int32.Parse(strUserNum);
            bool result_02 = inpValid_01(intUserNum);
            if(result_02 == true) 
            {
                sumRes++;
            }
            continue;
        }
        
    }    
}
