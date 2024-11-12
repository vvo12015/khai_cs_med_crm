using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal class Helper
    {
        public static List<Client> FindedClientFromForm(Client client)
        {

            List<Client> preparedList;
            List<Client> resultList = new List<Client>(MainForm.Clients);

            if (client.type != ClientType.UNKNOWN)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.type == client.type)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.name.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.name.Equals(client.name))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.edrpou.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.edrpou.Equals(client.edrpou))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.contractHours > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.contractHours.Equals(client.contractHours))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.size != CompanySize.UNKNOWN)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.size == client.size)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.ownerName.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.ownerName.Equals(client.ownerName))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.ownerPhone.Length == 18)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.ownerPhone.Equals(client.ownerPhone))
                    {
                        resultList.Add(fClient);
                    }
                }
            }


            if (client.ownerEmail.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.ownerEmail.Equals(client.ownerEmail))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            return resultList;
        }
    }
}
