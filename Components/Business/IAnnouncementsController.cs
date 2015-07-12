#region License

//
// DotNetNukeŽ - http://www.dotnetnuke.com
// Copyright (c) 2002-2012
// by DotNetNuke Corporation
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//

#endregion

#region Usings

using System;
using System.Collections.Generic;

using DotNetNuke.Entities.Users;

#endregion

namespace DotNetNuke.Modules.Announcements.Components.Business
{

    public interface IAnnouncementsController
    {

        void AddAnnouncement(AnnouncementInfo announcement);

        void UpdateAnnouncement(AnnouncementInfo announcement);

        void DeleteAnnouncement(int moduleID, int itemID);

        AnnouncementInfo GetAnnouncement(int itemID, int moduleID);

        IEnumerable<AnnouncementInfo> GetAnnouncements(int moduleId, DateTime startDate, DateTime endDate);

        IEnumerable<AnnouncementInfo> GetCurrentAnnouncements(int moduleId);

        IEnumerable<AnnouncementInfo> GetCurrentAnnouncements(int moduleId, DateTime startDate);

        IEnumerable<AnnouncementInfo> GetExpiredAnnouncements(int moduleId);

        void AddAnnouncementToJournal(AnnouncementInfo announcement, int tabId, String journalType);

        void SendNotifications(AnnouncementInfo announcement);

    }

}

