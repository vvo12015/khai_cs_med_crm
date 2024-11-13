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

            if (client.Type != ClientType.UNKNOWN)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Type == client.Type)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.Name.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Name.Equals(client.Name))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.EDRPOU.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.EDRPOU.Equals(client.EDRPOU))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.ContractHours > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.ContractHours.Equals(client.ContractHours))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.Size != CompanySize.UNKNOWN)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.Size == client.Size)
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.OwnerName.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerName.Equals(client.OwnerName))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            if (client.OwnerPhone.Length == 18)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerPhone.Equals(client.OwnerPhone))
                    {
                        resultList.Add(fClient);
                    }
                }
            }


            if (client.OwnerEmail.Length > 0)
            {
                preparedList = new List<Client>(resultList);
                resultList.Clear();

                foreach (Client fClient in preparedList)
                {
                    if (fClient.OwnerEmail.Equals(client.OwnerEmail))
                    {
                        resultList.Add(fClient);
                    }
                }
            }

            return resultList;
        }
    }
}
