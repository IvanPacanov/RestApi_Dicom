using RestApi_Dicom.Models;
using System.Collections.Generic;

namespace RestApi_Dicom.Data
{
 public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
    }
}