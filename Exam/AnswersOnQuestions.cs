
namespace Exam
{
    class AnswersOnQuestions
    {

        /*
         1) Изменить полностью строку нельзя, просто создается новая строка
         
         2) Рефлексия нужна чтобы узнавать типы классов , методов и интерфесйсов итд 
         using System.Reflection
         
        3) Сериализация - преобразование обьекта в поток байтов, обратное ему действие Десериализация

          var serializer = new XmlSerializer(typeof(Person));

            using (var stream = File.Create('file.xml'))
            {
                serializer.Serialize(stream, person);
            }

            using (var stream = File.OpenRead('file.xml'))
            {
                var results = serializer.Deserialize(stream) as Person;

                Console.WriteLine($'{results.id} , {results.fullName} , {results.age}');

                Console.ReadKey();
            }
           
         4)  class Transaction<T> where T: IDisposable

        5) Интерфейс - контракт, который говорит что длеать, но не говорит как делать
        также методы не имеют реализацию 
         не могут определять статические члены, переменные, константы
         
         
         У Абстрактного класа не можем использовать конструктор 

        Person p = new Person();
         
         
         
         
         
         
         
         
         */
    }
}
