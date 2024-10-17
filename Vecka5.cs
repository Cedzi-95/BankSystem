
//Den är public för att den är outerclass
// public class EffectService
// {
       //för att nå abstraktion vi behöver inte göra implementation public
//     private List<Effect> effects = new List<Effect>();

        //Denna method bli private. Encapsulation behövs i den här läge för att gömma implentationen.
//     private void Display(Effect effect)
//     {
//         effect.Display();
//         effects.Add(effect);
//     } 
       //Samma sak här med föra metoden
//     pivate void TickEffects()
//     {
//         Iterator<Effect> iter = effects.Iterator();
//         while(iter.HasNext())
//         {
//             Effect effect = iter.Next();
//             continue;
//         }
//         effect.Tick();
//     }
   //interface är public för metoder som var private i denna klass ska kunna  bli  ärvt eller anropad i andra klasser med hjälp av interface.
//     public interface Effect
// {
//     void Display();
//     void Tick();
//     bool ShouldTick();
// }

// }

//


//Outerclass är alltid public
// public class NetworkService
// {
       //Jag sätter properties som public, dem verkar innehålla implementation metoder som kan återanvändas i andra klasser
//     public useEpoll = Epoll.isAvailable();
//     public UUID serverId = UUID.randomUUID();
//     public string serverAddress = "";
        //Jag sätter den här klassen som private, den implementater Usepoll bollean 
//     private class <SocketChannelClass> channelClass = useEpoll ?
//     EpollSocketChannel.class
//     :
//     NioSocketChannel.class;
    //jag sätter private här också för samma anledning som föra klassen
//     private EventLoopGroup group = useEpoll ?
//     serverNetworkIo.EpollSocketChannel.get();
//     :
//     serverNetworkIo.DEFAULT_CHANNEL.get();
    
    //implementation här ocksp då sätter jag channel som private
//     private channel channel = null;

    //Jag sätter resten av metoder public
//     public void connect()
//     {
//         try
//         {
//             LOGGER.info("Trying to connect...");
            
//             this.channel = Boostrap()
//             .group(group)
//             .channel(channelClass)
//             .handler(this)
//             .connect("127.0.0.1", 25580)
//             .sync()
//             .channel()

//             serverAddress = $"{Server.serverIp}: ${Server.serverPort}"
//         channel.writeAndFlush(new HandshakePayload(serverId,serverAddress));

//         LOGGER.info("Connected as ${serverAddress}.")      
//         }
//         catch (Exception exception)
//         {
//             LOGGER.error("Could not connect, retrying in 5s")
//             reconnect();
//         }
//     }
//     public void reconnect()
//     {
//         executor.schedule(() => {
//             connect();
//         } , 5 , TimeUnit.SECOND);
//     }

//     public void send(OutboundPayload payload)
//     {
//         if (channel != null && channel.isOpen())
//         channel.write(payload)
//         else
//         {
            
//             {
//                 throw new IllegalStateException("Channel not open.");
//             }
//         }
//     }
