# -*- coding: utf-8 -*-
"""
Created on Tue Oct  4 17:12:31 2022

@author: ERIK
"""

from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padre(oscar,jose)")
prolog.assertz("padre(oscar,maria)")
prolog.assertz("padre(jose,william)")
prolog.assertz("padre(maria,jhoselin)")
prolog.assertz("padre(maria,erik)")

for elem in prolog.query("padre(X,Y),padre(Y,Z)"):
    print(elem["X"], "es el abuelo de", elem["Z"])
print()
for elem in prolog.query("padre(X,Y),padre(Y,Z)"):
    print(elem["Z"], "es el nieto de", elem["X"])
print()
for elem in prolog.query("padre(Y,A),padre(Z,B),padre(X,Y),padre(X,Z),(Y\==Z)"):
    print(elem["A"], "es el primo de", elem["B"])