namespace telephoneDirectory{
    class Program{
        static void Main(string[] args){

            List<Person> persons = new List<Person>();
            
           
            
            int i =1;
             int x=1;


             do{
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ******************************************* (1) Yeni Numara Kaydetmek (2) Varolan Numarayı Silmek (3) Varolan Numarayı Güncelleme (4) Rehberi Listelemek (5) Rehberde Arama Yapmak");

                int op = Convert.ToInt32(Console.ReadLine());
               
                if(op==1){
                    string name=Console.ReadLine();
                    string surname = Console.ReadLine();
                    int no = Convert.ToInt32(Console.ReadLine());
                    Person person = new Person();
                    person.Id=x;
                    person.Name=name;
                    person.Surname=surname;
                    person.No=no;
                    Person.addPerson(persons,person);
                    x++;
                }
                if(op==2){
                    string nameAndSurname = Console.ReadLine();
                    string[] deletePerson = nameAndSurname.Split(" ");

                    for(int a=0;a<persons.Count();a++){
                        if(persons[a].Name==deletePerson[0] && persons[a].Surname==deletePerson[1]){
                            Person.deletePerson(persons,persons[a].Id);
                            x--;
                        }
                    }

                 }

                 if(op==3){
                     string nameAndSurname = Console.ReadLine();
                    string[] updatePerson = nameAndSurname.Split(" ");

                    foreach(var item in persons){
                        if(item.Name==updatePerson[0] && item.Surname==updatePerson[1]){
                            int updateNo = Convert.ToInt32(Console.ReadLine());
                            Person.updateNumber(persons,item,updateNo);
                        }
                    }
                 }

                 if(op==4){
                    Person.listTelephone(persons);
                 }
                 if(op==5){
                    string nameAndSurname = Console.ReadLine();
                    string[] searchPerson = nameAndSurname.Split(" ");

                    foreach(var item in persons){
                        if(item.Name==searchPerson[0] && item.Surname==searchPerson[1]){
                            Person.searchPerson(persons,item);
                        }
                    }


                 }



              
                

             } while(i!=6);  
        }
    }
}

