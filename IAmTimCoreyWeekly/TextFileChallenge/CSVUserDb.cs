using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace TextFileChallenge
{
    public class CSVUserDb : IUserDb
    {
        private readonly string _fileName;

        public CSVUserDb(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
        }

        public IEnumerable<UserModel> LoadUsers()
        {
            var lines = File.ReadAllLines(_fileName);

            var propertyNames = lines.FirstOrDefault()?.Split(',');
            if (propertyNames == null)
            {
                return Enumerable.Empty<UserModel>();
            }

            return lines.Skip(1).Where(line => !string.IsNullOrWhiteSpace(line)).Select(line =>
            {
                var userModelPropertyValues = line.Split(',');
                return new UserModel
                {
                    Age = Convert.ToInt32(userModelPropertyValues[Array.IndexOf(propertyNames, "Age")]),
                    FirstName = userModelPropertyValues[Array.IndexOf(propertyNames, "FirstName")],
                    IsAlive = Convert.ToInt32(userModelPropertyValues[Array.IndexOf(propertyNames, "IsAlive")]) == 1,
                    LastName = userModelPropertyValues[Array.IndexOf(propertyNames, "LastName")]
                };
            });
        }

        public void SaveUsers(BindingList<UserModel> users)
        {
            var propertyNames = File.ReadAllLines(_fileName).First().Split(',');

            using (var streamWriter = new StreamWriter(_fileName))
            {
                streamWriter.WriteLine(string.Join(",", propertyNames));
                foreach (var user in users)
                {
                    var line = propertyNames.Select(propertyName =>
                    {
                        // ReSharper disable once PossibleNullReferenceException
                        var value = user.GetType().GetProperty(propertyName).GetValue(user).ToString();
                        return propertyName != "IsAlive" ? value : Convert.ToBoolean(value) ? "1" : "0";
                    });
                    streamWriter.WriteLine(string.Join(",", line));
                }
            }
        }
    }
}