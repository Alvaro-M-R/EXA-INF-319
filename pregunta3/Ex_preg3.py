# -*- coding: utf-8 -*-
"""
@author: Alvaro
"""
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("padre(jose,jesus)")
prolog.assertz("padre(jesus,sofia)")
prolog.assertz("padre(jesus,alejandro)")
prolog.assertz("padre(jose,juan)")
prolog.assertz("padre(jose,alvaro)")
prolog.assertz("padre(jose,gustavo)")
prolog.assertz("padre(gustavo,william)")
prolog.assertz("padre(gustavo,felipe)")
prolog.assertz("padre(gustavo,oscar)")
prolog.assertz("padre(gustavo,luis)")
prolog.assertz("padre(gustavo,sandra)")
prolog.assertz("padre(juan,manuel)")
prolog.assertz("padre(manuel,esteban)")
prolog.assertz("padre(manuel,antonio)")
prolog.assertz("padre(manuel,martin)")
prolog.assertz("padre(alvaro,tomas)")
prolog.assertz("padre(danilo,anabel)")


prolog.assertz("madre(maria,jesus)")
prolog.assertz("madre(magdalena,sofia)")
prolog.assertz("madre(magdalena,alejandro)")
prolog.assertz("madre(maria,juan)")
prolog.assertz("madre(maria,alvaro)")
prolog.assertz("madre(maria,gustavo)")
prolog.assertz("madre(josefina,anabel)")
prolog.assertz("madre(anabel,manuel)")
prolog.assertz("madre(clementina,esteban)")
prolog.assertz("madre(clementaina,antonio)")
prolog.assertz("madre(clementina, martin)")

#REGLAS
prolog.assertz("hijo(X,Y):-padre(Y,X)")
prolog.assertz("hijo(X,Y):-madre(Y,X)")

prolog.assertz("abuelo(X,Y):-padre(Z,Y),padre(X, Z)")
prolog.assertz("abuelo(X,Y):-madre(Z,Y),madre(X,Z)")

prolog.assertz("hermano(X,Y):-padre(Z,X),hijo(Y,Z),X\=Y") 
prolog.assertz("hermano(X,Y):-madre(Z,X),hijo(Y,Z),X\=Y")

prolog.assertz("tio(X,Y):-padre(Z,Y),hermano(Z,X)")
prolog.assertz("tio(X,Y):-madre(Z,Y),hermano(Z,X)")

prolog.assertz("esposos(X,Y):-padre(X,Z),madre(Y,Z)")
prolog.assertz("esposos(X,Y):-madre(X,Z),padre(Y,Z)")

prolog.assertz("sobrino(X,Y):-tio(Y,X)")


prolog.assertz("primo(X,Y):-padre(Z,Y),tio(Z,X)") 
prolog.assertz("primo(X,Y):-madre(Z,Y),tio(Z,X)")

prolog.assertz("cunado(X,Y):-hermano(Z,Y),esposos(Z,X)")
prolog.assertz("cunado(X,Y):-hermano(Z, X),esposos(Z,Y)")

prolog.assertz("nieto(X,Y):-abuelo(Y, X)")

prolog.assertz("bisabuelo(X,Y):-abuelo(X, Z),padre(Z,Y)")
prolog.assertz("bisabuelo(X,Y):-abuelo(X, Z),madre(Z,Y)")

prolog.assertz("bisnieto(X,Y):-bisabuelo(Y,X)")

prolog.assertz("yerno_nuera(X,Y):-hijo(Z,Y),esposos(X,Z)")

prolog.assertz("suegro(X,Y):-yerno_nuera(Y,X)")


#for elemento in prolog.query("padre(X,Y)"):
 #   print(elemento["X"], "es el padre de ",elemento["Y"])
for elemento in prolog.query("madre(X,Y)"):
    print(elemento["X"], "es madre de ",elemento["Y"])
'''
for elemento in prolog.query("hijo(X,Y)"):
    print(elemento["X"], "es hijo de ",elemento["Y"])
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es abuelo de ",elemento["Y"])
for elemento in prolog.query("hermano(X,Y)"):
    print(elemento["X"], "es hermano de ",elemento["Y"])
for elemento in prolog.query("tio(X,Y)"):
    print(elemento["X"], "es tio de ",elemento["Y"])'''
