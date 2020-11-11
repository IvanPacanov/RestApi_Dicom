using System.Collections.Generic;
using RestApi_Dicom.Models;

namespace RestApi_Dicom.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
    }
}