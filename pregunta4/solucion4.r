nroc<-c("A",2:10,"J","Q","K")
cartas<-c(rep(nroc,4))
simbol<-c("Corazon", "Diamante", "Trebol", "Espada")
simbolos<-c(rep(simbol,rep(13,4)))
color<-c(rep("rojo",13),rep("negro",13),rep("rojo",13),rep("negro",13))
baraja<-data.frame(cartas,simbolos,color)
baraja