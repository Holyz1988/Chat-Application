using System.Collections.Generic;

namespace Fasseto.Word

{
    /// <summary>
    /// The design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503",
                    NewContentAvailable = false,
        },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    NewContentAvailable = false,
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = false,

                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503",
                    NewContentAvailable = false,

                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    NewContentAvailable = false,

                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = false,

                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503",
                    NewContentAvailable = false,

                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    NewContentAvailable = false,

                },
            };
        }

        #endregion


    }
}
