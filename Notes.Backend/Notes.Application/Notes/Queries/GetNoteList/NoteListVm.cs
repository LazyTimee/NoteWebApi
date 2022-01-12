using System.Collections.Generic;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteListElemDto> Notes { get; set; }
    }
}
