using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeyPassInfoModel;

namespace KeyPassBusiness
{
    public delegate void GroupAddedEventHandler(Group g);
    public delegate void GroupModifiedEventHandler(Group g);
    public delegate void GroupDeletedEventHandler(Group g);

    public delegate void GroupSelectedEventHandler(Group g);
    public delegate void KeySelectedEventHandler(List<Key> keys);

    public delegate void KeyAddedEventHandler(Key k);
    public delegate void KeyModifiedEventHandler(Key k);
    public delegate void KeyDeletedEventHandler(Key k);

    public delegate void KeysSelectedEventHandler(List<Key> keys);

    public delegate void DocumentChangedEventHandler();
    public delegate void NewDocumentEventHandler();
    public delegate void DocumentOpenedEventHandler();
    public delegate void DocumentSavedEventHandler();
}
