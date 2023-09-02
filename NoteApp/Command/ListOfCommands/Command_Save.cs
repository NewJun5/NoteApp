using NoteApp.Assistive;

namespace NoteApp.Command
{
    public class Command_Save : ICommand
    {
        public ListOfItem ListOfNotes { get; set; }

        public Command_Save(ListOfItem listOfNotes)
        {
            ListOfNotes = listOfNotes;
        }

        public void ExecuteAction()
        {
            Save_toPC.Record(ListOfNotes);
            Notification.SuccessfulAction("Данные сохранены!");
            Notification.Info($"Имя файла: {Save_toPC.NameFileForRecord}, Директория:{Save_toPC.DirectoryPathForSaving}");

            Save_toDb.SaveToDb(ListOfNotes);
            Notification.Info($"Строка подключения: {Save_toDb.ConnectionString}, Имя таблицы:{Save_toDb.TableTitle}");
        }
    }
}
