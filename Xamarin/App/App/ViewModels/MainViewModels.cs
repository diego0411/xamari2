using System;
using System.Collections.Generic;
using System.Text;


namespace App.ViewModels
{
    //using Models;
    using System;
    using System.Collections.ObjectModel;
    class MainViewModels
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        #endregion
        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion
        #region Constructors
        public MainViewModels()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion
        #region Singleton
        private static MainViewModels instance;
        public static MainViewModels GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModels();
            }
            return instance;
        }
        #endregion
    }
}

