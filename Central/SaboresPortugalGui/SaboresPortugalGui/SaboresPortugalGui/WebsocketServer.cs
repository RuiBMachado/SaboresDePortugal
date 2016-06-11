using SaboresPortugalGui.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaboresPortugalGui
{
    class WebsocketServer
    {

        WebSocket webSocket;
        public async void Start(string httpListenerPrefix)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(httpListenerPrefix);
            httpListener.Start();
            Console.WriteLine("Espera");

            while (true)
            {
                HttpListenerContext httpListennerContext = await httpListener.GetContextAsync();
                if (httpListennerContext.Request.IsWebSocketRequest)
                {
                    ProcessRequest(httpListennerContext);
                }
                else
                {
                    httpListennerContext.Response.StatusCode = 400;
                    httpListennerContext.Response.Close();
                }
            }
        }
        public async void ProcessRequest(HttpListenerContext httpListenerContext)
        {

            WebSocketContext webSocketContext = null;
            try
            {
                webSocketContext = await httpListenerContext.AcceptWebSocketAsync(subProtocol: null);
                string ipAdress = httpListenerContext.Request.RemoteEndPoint.Address.ToString();
                Console.WriteLine("Conectado " + ipAdress);
                webSocket = webSocketContext.WebSocket;
                Tarefa a = new Tarefa();
                a.dataInicio = "dsad";
                trata(a);

             

            }
            catch (Exception e)
            {
                httpListenerContext.Response.StatusCode = 500;
                httpListenerContext.Response.Close();
                Console.WriteLine("Excepcaofffs" + e);
            }

        }

        public async void trata(Tarefa a)
        {



            try
            {

                byte[] receivedBuffer = new byte[1024];
                byte[] paraEnviar = new byte[1024];
                while(webSocket.State == WebSocketState.Open)
                {
                  //  WebSocketReceiveResult receiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(receivedBuffer), CancellationToken.None);

                    //if (receiveResult.MessageType == WebSocketMessageType.Close)
                      //  await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                    //else
                    //{

                        paraEnviar = ObjectToByteArray(a);

                        await webSocket.SendAsync(new ArraySegment<byte>(paraEnviar), WebSocketMessageType.Binary, false, CancellationToken.None);
                   
                    //}
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcao1" + e);
            }
            finally
            {
                if (webSocket != null) webSocket.Dispose();
            }
        }




        // Convert an object to a byte array
        private byte[] ObjectToByteArray(Object obj)
        {

            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
// Convert a byte array to an Object
private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);

            return obj;
        }
    }
}

       


