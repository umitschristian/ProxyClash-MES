﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Provinces : MonoBehaviour
{

    //isi
    public static uint pisi = 1277000;
    public static int rjisi = 79;
    public static int rmisi = 21;
    public static int eiisi = 79;
    public static int emisi = 14;
    public static int ecisi = 7;
    //ita
    public static uint pitsa = 1388400;
    public static int rjita = 92;

    public static int rcita = 4;
    public static int rmita = 4;
    public static int eiita = 92;
    public static int eaita = 6;
    public static int eeita = 1;
    public static int ecita = 1;
    //icd
    public static uint picd = 2115800;
    public static int rjicd = 90;
    public static int rcicd = 5;
    public static int rmicd = 5;
    public static int eicd = 90;
    public static int eanicd = 1;
    public static int eabicd = 9;

    //jas
    public static uint pjas = 475000;
    public static int rjjas = 15;
    public static int rcjas = 15;
    public static int rmjas = 70;
    public static int eijas = 15;
    public static int eajas = 85;
    //ij
    public static uint pij = 1083000;
    public static int rjij = 70;
    public static int rmij = 28;
    public static int rcij = 2;
    public static int eiij = 70;
    public static int eabij = 28;
    public static int eanij = 2;
    //igh
    public static uint pigh = 90000;
    public static int rjigh = 10;
    public static int rmigh = 90;
    public static int eiigh = 10;
    public static int eaigh = 90;
    //nuetral
    //nd
    public static uint nd = 1080000;

    public static int rmnd = 100;

    public static int eand = 100;
    //nas
    public static uint pnas = 770000;
    public static int rdnas = 88;
    public static int rcnas = 11;
    public static int rmnas = 1;
    public static int ednas = 88;
    public static int egnas = 11;
    public static int eanas = 1;
    public static uint bnas = 1000000000;
    //nrd
    public static uint pnrd = 2100000;
    public static int rmnrd = 80;
    public static int rcnrd = 20;
    public static int eanrd = 100;
    public static uint bnrd = 2000000000;
    //nhs
    public static uint pnh = 1803000;
    public static int rmnh = 90;
    public static int rcnh = 10;
    public static int eabnh = 80;
    public static int eknh = 10;
    public static int eannh = 10;
    public static long bnh = 30000000000;
    //nha
    public static uint pnha = 1682000;
    public static int rsnha = 95;
    public static int rcnha = 5;
    public static int eabnha = 90;
    public static int eknha = 5;
    public static int eannha = 5;
    public static long bnha = 20000000000;
    //nl
    public static uint pnl = 1890000;
    public static int ranl = 100;
    public static int eanl = 48;
    public static int ecnl = 10;
    public static int esmnl = 35;
    public static int einl = 2;
    public static long bnl = 10000000000;
    //nt 
    public static uint pnt = 750000;
    public static int rnt = 100;
    public static int eant = 89;
    public static int ecnt = 11;
    public static long bnt = 10000000000;
    //ni
    public static uint pni = 1500000;
    public static int rani = 80;
    public static int rkni = 20;
    public static int esni = 100;
    public static long bni = 30000000000;
    //na
    public static uint pna = 4868000;
    public static int rana = 10;
    public static int rkna = 15;
    public static int rtna = 5;
    public static int esna = 100;
    public static long bna = 5000000000;
    //nr
    public static uint pnr = 960000;
    public static int ranr = 95;
    public static int rknr = 5;
    public static int esnr = 100;
    public static long bnr = 40000000000;
    //nah
    public static uint pnah = 1500000;
    public static int ranah = 70;
    public static int rknah = 30;
    public static int esnah = 95;
    public static int eynah = 5;
    public static long bnah = 25000000000;
    //dez
    public static uint pdez = 1239000;
    public static uint radez = 60;
    public static uint rkdez = 40;
    public static uint esdez = 90;
    public static uint eydez = 10;
    public static long bdez = 15000000000;
    //naa

    public static int pnaa = 1800000;
    public static int ranaa = 100;
    public static int esnaa = 100;
    public static long bnaa = 20000000000;
    //nm
    public static int ranm = 90;

    public static int rpnm = 10;

    public static int esinm = 90;

    public static int esanm = 10;

    public static long bnm = 15000000000;
    //aq
    public static uint paq = 1320000;
    public static int raaq = 90;
    public static int rpaq = 10;
    public static int esiaq = 90;
    public static int esaaq = 10;
    public static long baq = 200000000000;
    //nbl
    public static int pnb = 2000000;
    public static int ranb = 90;
    public static int rpnb = 10;
    public static int esinb = 90;
    public static int esanb = 10;
    public static long bnb = 45000000000;
    //nbd
    public static uint pnbd = 13500000;
    public static int ranbd = 100;
    public static int esinbd = 60;
    public static int esanbd = 40;
    public static long bnbd = 2000000000000;
    //nba
    public static uint pnba = 4700000;
    public static int ranba = 100;
    public static int esinba = 70;

    public static int esanba = 30;
    public static long bnba = 150000000000;
    //ndq
    public static uint pndq = 2000000;
    public static int andq = 100;
    public static int sindq = 50;
    public static int sandq = 50;
    public static long bndq = 50000000000;
    //nd
    public static uint pnd = 1443000;
    public static int rand = 100;
    public static int esind = 50;
    public static int esand = 50;
    public static long bnd = 65000000000;
    //nka
    public static uint pnka = 1370000;
    public static int ranka = 100;
    public static int rsinka = 50;
    public static int rsanka = 50;
    public static long bnka = 35000000000;
    //nkk
    public static uint pnkk = 1259000;
    public static int rankk = 100;
    public static int esinkk = 50;
    public static int esankk = 50;
    public static long bnkk = 25000000000;
    //nmn
    public static int pnmn = 1412000;
    public static int ranmn = 100;
    public static int esanmn = 60;
    public static int esinmn = 40;
    public static long bnmn = 25000000000;
    //nnf
    public static uint pnnf = 1312000;
    public static int rannf = 100;
    public static int esannf = 60;
    public static int esinnf = 40;
    public static long bnnf = 35000000000;
    //nnh
    public static uint pnnh = 3270000;
    public static int rannh = 100;
    public static int esinnh = 80;
    public static int esannh = 20;
    public static long bnnh = 50000000000;
    //ns
    public static uint pns = 1408000;
    public static int rans = 100;
    public static int esins = 80;
    public static int esans = 20;
    public static long bns = 75000000000;
    //nw
    public static uint pnw = 1149000;
    public static int ranw = 100;
    public static int esinw = 90;
    public static int esanw = 10;
    public static long bnw = 10000000000;
    //ndk
    public static uint pndk = 1089000;
    public static int rkndk = 90;
    public static int randk = 10;
    public static int eyndk = 20;
    public static int esndk = 80;
    public static long bndk = 45000000000;
    //irainian
    //iaz
    public static uint pia = 271200;
    public static int rsia = 95;
    public static int rcia = 5;
    public static int epia = 65;
    public static int esaia = 30;
    public static int eaia = 5;
    //ial
    public static uint pial = 1270000;
    public static int rsial = 90;
    public static int rcial = 10;
    public static int epial = 80;
    public static int eaiial = 10;
    public static int eanial = 10;
    //iea
    public static uint piea = 3742000;
    public static int rsaiea = 80;
    public static int rsiiea = 10;
    public static int rciea = 10;
    public static int eaiiea = 80;
    public static int epiea = 10;
    public static int eaniea = 10;
    //iwa
    public static uint piwa = 3080000;
    public static int rsiwa = 90;
    public static int rciwa = 10;
    public static int easiwa = 90;
    public static int eaniwa = 10;
    //ib
    public static uint pib = 1463000;
    public static int rsib = 100;
    public static int epib = 60;
    public static int eaib = 40;
    //icb
    public static uint picb = 947000;
    public static int rsicb = 100;
    public static int ebicb = 55;
    public static int epicb = 31;
    public static int eqicb = 13;
    //ik
    public static uint pik = 4780000;
    public static int rsaik = 95;
    public static int rsiik = 5;
    public static int epik = 65;
    public static int ecik = 30 ;
    public static int egik = 1;
    public static int ekik = 1;
    public static int eaik = 3;
    //igi
    public static uint pigi =25350000 ;
    public static int rsigi = 100;
    public static int egigi= 45;
    public static int etigi = 45;
    public static int eaigi = 10;
    //igo
    public static uint pigo = 1868000;
    public static int rsigo =99;
    public static int rcigo =1 ;
    public static float etigo = 34.20f;
    public static int emigo = 30;
    public static float esigo = 10.2f;
    public static float eqigo = 7.3f;
    public static int eanigo = 1;
    public static int eaiigo =1 ;
    //iha
    public static uint piha = 1758000;
    public static int rsaiha =99;
    public static int rsiiha =1 ;
    public static int epiha =70 ;
    public static int eaiha =22 ;
    public static int eliha =8 ;
    //iho
    public static uint piho = 1776000;
    public static int rsaiho =99;
    public static int rsiiho = 1;
    public static int epiho =90 ;
    public static int ebiho = 10;
    //il
    public static uint pil =557000 ;
    public static int rsil =100 ;
    public static int ekil =80 ;
    public static int elril = 11;
    public static int elkil =6;
    public static int epil =2 ;
    public static int eail =2 ;

    //ii
    public static uint pii = 5120000;
    public static int rsii = 100;
    public static int epii =90 ;
    public static int elii =10 ;
    //ikn
    public static uint pikn = 3164000;
    public static int rpikn =95 ;
    public static int rbikn = 5;
    public static int rsaikn = 95;
    public static int rsiikn = 5;
    //ikh
    public static uint pikh = 1952000;
    public static int rsaikh =99;
    public static int rsiikh = 1;
    public static int epikh =99;
    public static int ebikh = 1;
    //inkp
    public static uint pinkp = 867000;
    public static int rpinkp = 95;
    public static int rtinkp =5;
    public static int esinkp =100;
    //irk
    public static uint pirk=5994000 ;
    public static int rpirk = 99;
    public static int rtirk =1;
    public static int esirk =100 ;
    //iks
    public static uint piks =768000 ;
    public static int rpiks = 99;
    public static int rtiks =1;
    public static int esiks = 100;
    //ikp
    public static uint pikp =4711000 ;

    public static int rpikp = 95;
    public static int rkikp = 5;
    public static int esaikp =95;
    public static int esiikp = 5;
    //ikba
    public static uint pikba =658000 ;
    public static int rpikba = 90;
    public static int rbikba = 10;
    public static int rsikba = 100;
    //ikn
    public static uint piku= 1603000;
    public static int rkiku = 65;
    public static int rpiku =35 ;
    public static int esiku =100 ;
    //iln
    public static uint piln = 1716000;
    public static int rliln =65 ;
    public static int rpiln = 35;
    public static int rsiln =100 ;
    //im
    public static uint pim = 1429000;
    public static int rpim =100;
    public static int rsim = 100;
    //imn
    public static uint pimn = 3073000;
    public static int rmimn =95 ;
    public static int rpimn =5 ;
    public static int esimn = 100;
    //iqn
    public static uint piqn =1273000;
    public static int rpiqn = 85;
    public static int rkiqn = 15 ;
    public static int esiqn =100;
    //iqm
    public static uint piqm =1151000;
    public static int rpiqm =100 ;
    public static int esiqm =100;
    //isn
    public static uint pisn =631000;
    public static int rpisn =100 ;
    public static int esisn = 100;
    //isb
    public static uint pisb = 2775000;
    public static int rpisb = 80;
    public static int rbisb =20 ;
    public static int esaisb = 80;
    public static int esiisb = 20;
    //it
    public static uint pit =15000000 ;
    public static int rpit =95 ;
    public static int rait =5 ;
    public static int esit =94;
    public static int ejit =1 ;
    public static int eait =5 ;
    //iy
    public static uint piy = 1138900;
    public static int rpiy = 100;
    public static int esiy =100 ;
    //iz
    public static uint piz = 1015000;
    public static int raiz = 65;
    public static int rtiz = 35;
    public static int esiz =100 ;










}
     























