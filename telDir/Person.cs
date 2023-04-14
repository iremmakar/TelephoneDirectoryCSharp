namespace telephoneDirectory{
    class Person{
        private int id;
        private string name="d";
        private string surname="s";
        private int no;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public int Id { get => id; set => id = value; }

        public static void addPerson(List<Person> persons,Person person){
            persons.Add(person);
        }

        public static void deletePerson(List<Person> persons,int no){
            persons.RemoveAt(no-1);
        }

        public static void updateNumber(List<Person> persons,Person person,int no){

           person.No=no;
        }

        public static void listTelephone(List<Person> persons){

            foreach (var item in persons)
            {
                Console.WriteLine("isim: "+item.Name+" soyisim: "+item.Surname+" Telefon Numarası: "+item.No);
            }

        }

        public static void searchPerson(List<Person> persons,Person person){

              
                    Console.WriteLine("isim: "+person.Name+" soyisim: "+person.Surname+" Telefon Numarası: "+person.No);
                
        }

    }

}
