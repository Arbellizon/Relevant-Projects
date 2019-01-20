
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string>
#include <cstring>
#include <sstream>
#include <fstream>
#include <cerrno>

    using namespace std;

    class Vigenere
{
        public:string key;

    Vigenere(string Encryption_Key)
    {
        for(int i = 0; i < Encryption_Key.size(); ++i)
            {
                if (Encryption_Key[i] >= 'A' && Encryption_Key[i] <= 'Z')
                        {this->key += Encryption_Key[i]; }

                else if (Encryption_Key[i] >= 'a' && Encryption_Key[i] <= 'z')
                        {this->key += Encryption_Key[i] + 'A' - 'a'; }
            }
    }


        string Encrypt(string Plain_Text)
        {

            string Encryption;

            for(int i = 0, j = 0; i <= Plain_Text.length(); ++i)
            {
                char c = Plain_Text[i];

                if(c >= 'a' && c <= 'z')
                    {c += 'A' - 'a'; }

                else if (c < 'A' || c > 'Z')
                    {continue; }

                Encryption += (c + key[j] - 2 * 'A') % 26 + 'A';

                j = (j + 1) % key.length();

            }

                return Encryption;

            }

            string Decrypt(string Decrypt_Text)
            {
                string Decrypted;

            for (int i = 0, j = 0; i <= Decrypt_Text.length(); ++i)
            {
                char c = Decrypt_Text[i];

                if (c >= 'a' && c <= 'z')
                    {c += 'A' - 'a'; }

                else if (c < 'A' || c > 'Z')
                    {continue; }

                Decrypted += (c - key[j] + 26) % 26 + 'A';

                j = (j + 1) % key.length();

            }

                return Decrypted;

            }

    };

    string OpenFile()
    {
        fstream File;

        string filename;
        string  filedata;
        stringstream DataBuffer;

        cout<<"To start, please enter the name of the you want to Encrypt or Decrypt, along with file ext (i.e .txt)"<<endl;
        getline(cin, filename);

        File.open(filename.c_str());

        DataBuffer<< File.rdbuf();

        filedata= DataBuffer.str();
        //File.close();

        return filedata;
    }

void WriteFile(string data)
{

    string filename;
    fstream Senddata;

    cout<<"Please enter a file to save to, along with file ext (i.e .txt)"<<endl;
    getline(cin, filename);



    if(!Senddata.is_open())
    {
        perror("This following error has occured");
        exit(0);
    }
    else
    {
        Senddata<< data;
        cout<<"file has been successfully saved"<<endl;
        Senddata.close();
    }
}
    int main()

    {
        char choice;
        Vigenere Secret_Key("MyKey");

        while(choice !=  'q' || choice != 'Q')
        {

            string text = OpenFile();
            cout<<"Would you like to encrypt or decrypt a file?"<<endl;
            cout<<"Now either press E to Encrypt or D to Decrypt:"<<endl;
            cin>>choice;


            switch(choice)
            {
            case 'E':
            case 'e':
                {

                    string ToFile = Secret_Key.Encrypt(text);
                    cout<<ToFile;
                    WriteFile(ToFile);
                    exit(0);
                }
                case 'D':
                case 'd':
                {
                    string Decoded =Secret_Key.Decrypt(text);
                    cout<<Decoded;
                    WriteFile(Decoded);
                    break;
                }
                case 'Q':
                case 'q':
                exit(0);
                break;

                default:
                    break;
            }

        }
        return 0;

    }
