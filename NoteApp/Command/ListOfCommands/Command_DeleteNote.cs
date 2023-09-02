using NoteApp.Assistive;


namespace NoteApp.Command
{
    public class Command_DeleteNote : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_DeleteNote(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {

            if (ListOfNotes.Count == 0)
                Notification.Info("Вас список заметок пуст!");
            else
            {
                Console.Write("Введите номер заметки, которую вы хотите удалить: ");
                int numberNote = Checking.ToCheckEnteredStrCommand(Console.ReadLine());

                if (ListOfNotes.DeleteNote(numberNote))
                {
                    //выравнивание последовательно id
                    Helper.CorrectId(ListOfNotes, numberNote);

                    Notification.SuccessfulAction($"Заметка под номером {numberNote} успешно удалена!");
                }
                else
                    Notification.Attention("Операция удаления не прошла. Проверьте коректность данных и попробуйте еще раз!");                
            }
            Console.WriteLine();
        }
    }
}
