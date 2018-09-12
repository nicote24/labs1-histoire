using System;
using System.Timers;

namespace Labo1_histoire
{

    class Program
    {


        static void Main(string[] args)
        {
            //Variables
            int Choix1 = 0;
            int ChoixRace = 0;
            int Choix2 = 0;
            int Chance1 = 0;
            int Choix3 = 0;
            int Choix4 = 0;
            int Chance2 = 0;
            int Choix5 = 0;
            int Choix6 = 0;
            int Choix7 = 0;
            string Choix8 = "";

            //Affichage
            Console.WriteLine("Bonjours jeune épéiste et bienvenue dans SwordLordFantasy le nouveau MMORPG dont l'épée sera la seule arme que vous pourrez manier afin de survivre au niveau qui vous attends. ");
            Console.WriteLine("Veuillez choisir votre race:");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Vous souhaitez devenir un elfe épéiste(Appuyez sur 1)");
            Console.WriteLine("");
            Console.WriteLine("Vous souhaitez devenir un humain épéiste(Appuyez sur 2)");
            Console.WriteLine("");

            //Saisie
            ChoixRace = Convert.ToInt32(Console.ReadLine());

            if (ChoixRace == 1)
            {
                //Affichage
                Console.WriteLine("Vous choisisez la race des elfes, vous apparaisez avec une fine lame mais vous posséder d'étonnantes capacités en vitesse et en reflexe, mais vous êtes fragile. Vous avez devant vous 2 portes en bois la première mène au Boss où il est recommander d'etre niveau 5 et la porte 2 mène dans le premier monde ou vous pourrez monter de niveau et vous procurez de l'équipement");
                Console.WriteLine("Vous devez choir:");
                Console.WriteLine("------------------------------------------------------------------------------------------");

                //CHOIX 2 CI-DESSOUS
                Console.WriteLine("Vous entrez dans la salle du boss(Appuyez sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Vous allez dans le monde 1 de SwordLordFantasy(Appuyez sur 2)");
                Console.WriteLine("");

                //saisie
                Choix2 = Convert.ToInt32(Console.ReadLine());

                if (Choix2 == 1)
                {
                    //Affichage
                    Console.WriteLine("Vous pénétrez dans la salle du boss, son enorme masse arrive sur vous, cependant si la chance est de votre côté vous parviendrez à l'éviter");
                    Console.WriteLine("");
                    Random aleatoire = new Random();
                    Chance1 = aleatoire.Next(1, 11);

                    if (Chance1 >= 6)
                    {
                        //Afficahge
                        Console.WriteLine("Vous parvenez à évier la masse mais cependant sa corne vous transperce et vous mourrez.FIN.RECOMMENCEZ");
                    }

                    else if (Chance1 <= 5)
                    {
                        //Affichage
                        Console.WriteLine("Vous recevez la masse en pleine tête et vous mourrez. FIN.RECOMMENCEZ ");
                    }

                }

                else if (Choix2 == 2)
                {

                    //CHOIX 3 CI-DESSOUS

                    //Affichage
                    Console.WriteLine("Vous allez dans le monde afin de prendre de l'exéprience, mais dès que vous apparaissez, un goblin vous attaque par la droite.");
                    Console.WriteLine("Vous devez choisir :");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("Vous bloquez le coup avec votre lame(Appuyez sur 1)");
                    Console.WriteLine("");
                    Console.WriteLine("Vous tantez d'éviter le coup(Appuyez sur 2)");
                    Console.WriteLine("");

                    //Saisie
                    Choix3 = Convert.ToInt32(Console.ReadLine());

                    if (Choix3 == 1)
                    {
                        //Affichage
                        Console.WriteLine("Vous essayez de parer le coups mais puisque vous êtes fragile et possédez une fine lame , il brise votre garde et vous tue. FIN.RECOMMENCEZ");
                    }
                    else if (Choix3 == 2)
                    {

                        //choix4 CI-DESSOUS

                        //Affichage
                        Console.WriteLine("Puisque vous êtes rapide et agile, vous évitez largement son coup et vous vous préaprez à contre attaquer.");
                        Console.WriteLine("Vous devez choisir:");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("Vous lui coupez les tendons afin qu'il tombe(Appuyez sur 1)");
                        Console.WriteLine("");
                        Console.WriteLine("Vous lui transpercez le dos de votre lame(Appuyez sur 2)");
                        Console.WriteLine("");


                        //Saisie
                        Choix4 = Convert.ToInt32(Console.ReadLine());

                        if (Choix4 == 1)
                        {
                            //Affichage
                            Console.WriteLine("Vous attaquez donc les tendons de votre adversaire, la lame tranche bien sa cible et le goblin perd l'équilibre. Vous lui donnez alors le coup de grace et recevez alors de l'expérience");
                            Console.WriteLine(" ");
                            Random aleatoire = new Random();
                            Chance2 = aleatoire.Next(1, 3);
                            Console.WriteLine("vous recupérez alors " + Chance2 + " niveau(x)");

                            if (Chance2 == 1)
                            {
                                //CHOIX5 CI-DESSOUS

                                //Affichage

                                Console.WriteLine("");
                                Console.WriteLine("Vous gagnez donc un niveau et vous passez niveau 2. Vous marchez donc sur le chemin devant creuser dans la plaine dont la lune illumine de sa lumière la nuit. Vous arrivez devant une intersection où il est recommandé pour les joueurs de niveau 2 d'aller a droite et ceux de niveau 3 d'aller a gauche. Vous allez donc a droite et après queques heures vous arrivez a un village calme jusqu'à ce qu'une femme pousse un crie de mort dans la ruelle marchande sur votre droite. ");
                                Console.WriteLine("Vous devez donc choisir:");
                                Console.WriteLine("------------------------------------------------------------------------------------------");
                                Console.WriteLine("Vous allez dans la ruelle voir ce qui se passe(Appuyez sur 1)");
                                Console.WriteLine("");
                                Console.WriteLine("Vous ignorez ce cris et continuez votre route(Appuyez sur 2)");
                                Console.WriteLine("");

                                //Saisie
                                Choix5 = Convert.ToInt32(Console.ReadLine());

                                //CHOIX6 CI-DESSOUS

                                //Affichage

                                if (Choix5 == 1)
                                {
                                    Console.WriteLine(" Vous accourez donc dans cette ruelle sombre, mais plus vous avancez plus un brouillard épais apparait... Il n'y a personne vous vous retournez mais trop tard , vous sentez un lame froide vous coupez la gorge, vous n'avez rien pus faire, vous n'avez rien pus faire, vous n'avez rien pus voir. FIN.RECOMMENCEZ");

                                }
                                else if (Choix5 == 2)
                                {
                                    Console.WriteLine("Votre tempérament indiférent vous à été favorable cette fois-ci, une créature (surment celle qui à tentez de vous appater dans cette ruelle) sort du brouillard que contenait cette ruelle et se tire sur vous avec une vitesse étonnante mais vous avez le temps de l'esquiver ce qui n'aurait pas été le cas dans cette ruelle, elle reviens alors a la charge . ");
                                    Console.WriteLine("Vous dez alors choisir:");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    Console.WriteLine(" Vous parez le coup afin de tenter de la tuer directement(Appyez sur 1)");
                                    Console.WriteLine("");
                                    Console.WriteLine("Vousévitez le coup afin d'Avoir un angle optimal pour la tuer(Appuyez sur 2)");
                                    Console.WriteLine("");

                                    //Saisie
                                    Choix6 = Convert.ToInt32(Console.ReadLine());

                                    //Afficahge

                                    //CHOIX 7 CI-DESSOUS

                                    if (Choix6 == 1)
                                    {
                                        Console.WriteLine("La créature qui a constaté votre vitesse et regardé votre précédent combat anticipe une esquive de votre part et frappe dans le vide puisque vous n'esquivez pas , dans son elan elle est projettée contre votre lame qui avait pour but de contrer son attaque. Vous avez tué la créature et passez niveau 5 , un portail souvre alors celui ou se trouve le boss de ce monde. vous êtes aspiré par ce portail... ");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous reprenez vos esprtis quelques instant plus tard dans la salle de ce boss. Le boss se tien devant vous. C'est un immense dragon. Il vous regarde et en un istant c'est hp apparaissent au-dessus de lui. il possède 100hp");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous devez réfléchir à un plan de match afin de vaincre ce boss, 3 options s'offre a vous: ");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("vous bloquez afin de voir qu'elle est sa puissance de frappe(appuyez sur 1)");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous attaquez avant lui pour ensuite esquiver(appuyez sur 2)");
                                        Console.WriteLine("");
                                        Console.WriteLine("vous foncez sur le dragon à la facon DeadPool afin de L'attaquer tout en évitant les attaques(appuyez sur 3)");
                                        Console.WriteLine("");

                                        //Saisie
                                        Choix7 = Convert.ToInt32(Console.ReadLine());

                                        if (Choix7 == 1)
                                        {
                                            Console.WriteLine("Êtes-vous cinglé ? comment avez vous pus penser bloquer le feu d'un dragon avec une simple lame? Vous mourrez d'attroce souffrances dans les flammes du dragon. FIN.RECOMMENCEZ");
                                        }
                                        else if (Choix7 == 2)
                                        {
                                            Console.WriteLine("Tentez-vous sérieusement de prendre un boss de vitesse? LE boss réagis très mal a votre attaque vous contre avec ses griffes meurtrière et vous tue. FIN.RECOMMENCEZ");
                                        }
                                        else if (Choix7 == 3)
                                        {
                                            //CHOIX 8 CI-DESSOUS

                                            //Affichage

                                            Console.WriteLine("Vous attaquez à la DeadPool et vous parvenez après plusieurs esquive à le toucher mais ses écaille sont trop dures. Vous reculez alors et courez dans la pièce en evitant les attaques du boss tout en pensant à une solution. Vous devez trouver l'endroit de son corps où frapper afin de térasser la bête.");
                                            Console.WriteLine("Écrivez le nom de la partie du corp du dragon à frapper dessous:");

                                            //saise
                                            Choix8 = Console.ReadLine();

                                            if (Choix8.ToLower() == "ventre")
                                            {

                                                Console.WriteLine("");
                                                Console.WriteLine("Vous vous attaquerez alorsle ventre du dragon. vous vous glissez jusqu'a son immense ventre tout en évitant ses multiples attaques. Arrivé sous son ventre , vous courez et déchirrez le ventre de la bête en deux sous. Après un cri de mort démentiel, il s'éffondre! Vous montez directement niveau 10");
                                                Console.WriteLine("");
                                                Console.WriteLine("Félicitation vous avez terminé la béta du jeux. Vous pourez vous procurez le jeux jamais haha! Le jeux aurait compté 50 monde et 50 boss à tuer , dommage que ce ne sois qu'une béta ;) ");
                                                Console.WriteLine("Crée par Nicolas Côté... FIN");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Vous n'avez pas saisie la bonne partie du corps à frapper, lors de votre essaie le dragon vous carbonise sur le champs. Vous mourrez. FIN.RECOMMENCEZ");
                                            }

                                        }


                                    }
                                    else if (Choix6 == 2)
                                    {
                                        Console.WriteLine("La créature à enticipé votre esquive et parvient a vous trancherla gorge de sa froide dague . Vous mourrez. FIN.RECOMMENCEZ");

                                    }



                                }

                            }
                            else if (Chance2 == 2)
                            {

                                //CHOIX 5 CI-DESSOUS

                                //Affichage
                                Console.WriteLine("Vous gagnez donc deux niveau et vous passez niveau 3. Vous marchez donc sur le chemin devant creusé dans les plaines dont la lune illumine de sa lumière la nuit. Vous arrivez devant une intersection ou il est recommandé pour les joueurs de niveau 2 d'aller a droite et ceux de niveau 3 d'aller a gauche. Vous allez donc a gauche et après quelques minutes de marche vous arrivez dans un village ou il n'y a personne, ny même un bruit.");
                                Console.WriteLine("");
                                Console.WriteLine(" Plus vous pénétrez dans le village et plus vous entendez des cris , des hurlement de souffrances.. Tous viennent d'un endroit , cet eglise située au millieu de cet étrange village, vous devez choisir");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Vous entrez dans l'église par la porte principale afin de voir se qui s'y passe (Appuyez sur 1)");
                                Console.WriteLine("");
                                Console.WriteLine(" Vous attendez que quelqu'un sorte afin de ne pas vous mettre en danger (Appuyez sur 2)");
                                Console.WriteLine("");
                                Console.WriteLine("Vous essayez de quitter la zone (appuyez sur 3) ");
                                Console.WriteLine("");

                                //Saisie ( HEY je me suis rendu compte que l'on peu mettre choix 1 car il est deja utilisé :D
                                Choix1 = Convert.ToInt32(Console.ReadLine());

                                if (Choix1 == 1)
                                {
                                    Console.WriteLine("Vous entrez dans l'église,et ce que vous appercevez est tout bonnement horrible, une centaine de personne se tiens à l'intérieur d'un énorme cercle magique ou leurs énergie vitale est absorbée.");
                                    Console.WriteLine("Vous arrivez cepedant au mauvais moment et vous êtes aspiré par ce cercle...  une fois dedans impossbile d'en sortir ou dele briser de l'intérieur. Vous mourrez. FIN.RECOMMENCEZ");
                                }
                                else if (Choix1 == 2)
                                {
                                    Console.WriteLine("Vous attendez et voyez un jeune mage au yeux mauves sortir enfin , il vous appercois et vous lance un sort si immense qu'il est impossible à éviter , vous tentez de parer mais la magie transperce votre arme et vous tue . FIN.RECOMMENCEZ");

                                }
                                else if (Choix1 == 3)
                                {
                                    //Choix 6 CI-DESSOUS

                                    //Affichage

                                    Console.WriteLine("Vous tentez de quitter la zone mais sur le chemin vous rencontrez un enfants qui s'était visiblement caché, il vous raconte alors qu'un mage noir et puissant est arrivé en ville aujourd'hui et pratique sur les villagois de la magie noir afin de détruire le pays entier.");
                                    Console.WriteLine("");
                                    Console.WriteLine("L'enfant vous supplies de l'aider , Vous devez Choisir:");
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Vous décicez d'aider l'enfant ( Appuyez sur 1)");
                                    Console.WriteLine("");
                                    Console.WriteLine("Vous continuez votre route ( Appuyez sur 2)");
                                    Console.WriteLine("");

                                    //Saisie
                                    Choix3 = Convert.ToInt32(Console.ReadLine());

                                    if (Choix3 == 1)
                                    {
                                        //Affichge

                                        //Choix 7 CI-DESSOUS
                                        Console.WriteLine("Vous dites donc à l'enfant que vous arretez ce mage. L'enfant vous expliqua que le mage n'a pas pus s'attaquer a lui car il possédait une amulette anti-magie. Il vous fit cadeau de son amulette qe vous accrochez directement a votre épée.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous foncez donc à l'église mais une fois arrivé, plus aucun bruit , seulement le mage qui attendais votre arrivé se tenait debout. Les habitants étais tous évanouie , au seuil de la mort.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Le mage vous attaque avec une boule de magie énormemais vous la désintégrez facielement avec votre épée équipée de son amulette.Vous foncez sur lui épé à la main en brisant sa magie. Vous le meacez mainteant de votre épé");
                                        Console.WriteLine("Vous devez choisir :");
                                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("Vous lui laissez la vie et lui forcé a rendre l'énergie a tout le monde (appuyez sur 1)");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous lui tranchez la gorge (Appuyez sur 2)");
                                        //Saisie

                                        Choix1 = Convert.ToInt32(Console.ReadLine());

                                        if (Choix1 == 1)
                                        {
                                            Console.WriteLine(" Vous retirez votre épée de sa gorge mais si tôt fait il vous transperca d'une lame que vous aviez jamais remarqué. Votre coeur est touché . FIN");
                                        }
                                        else if (Choix1 == 2)
                                        {
                                            Console.WriteLine("Au moment ou vous lui tranchez la gorge , il vous transperca d'une lame que vous aviez jamais remarqué. Aucune zone vitale est touchée mais vous vous évanouissez alors qu'il meurt. ");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous montez niveau 5");
                                            Console.WriteLine("Vous vous réveillez dans une maison entouré des villagois et de l'enfant. pour vous remercié ceux-ci vous ont soigné et vous donne une clé que dès que vous prendrez en main vous serez téléporté en face du boss du niveau 1 de ce jeu ");
                                            Console.WriteLine("Vous remerciez les villagois et prenez la clé en main. Elle s'évapore de si tôt. Un portail souvre et vous êtes asprié dedans");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous reprenez vos esprtis quelques instant plus tard dans la salle de ce boss. Le boss se tien devant vous. C'est un immense dragon. Ils vous regarde et en un istant c'est hp apparaissent au-dessus de lui. il possède 100hp");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous devez réfléchir à un plan de match afin de vaincre ce boss, 3 option s'offre a vous: ");
                                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                            Console.WriteLine("vous bloquez afin de voir qu'elle est sa puissance de frappe(appuyez sur 1)");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous attaquez avant lui pour ensuite esquiver(appuyez sur 2)");
                                            Console.WriteLine("");
                                            Console.WriteLine("vous foncer sur le dragon à la facon DeadPool afin de L'attaquer tout en évitant les attaques(appuyez sur 3)");
                                            Console.WriteLine("");

                                            //Saisie
                                            Choix7 = Convert.ToInt32(Console.ReadLine());

                                            if (Choix7 == 1)
                                            {
                                                Console.WriteLine("Êtes-vous cinglé ? comment avez vous pus penser bloquer le feu d'un dragon avec une simple lame? Vous mourrez d'attroce souffrances dans les flammes du dragon. FIN");
                                            }
                                            else if (Choix7 == 2)
                                            {
                                                Console.WriteLine("Tentez-vous sérieusement de prendre un boss de vitesse? LE boss réagis très mal a votre attaque vous contre avec ses griffes meurtrière et vous tue. FIN");
                                            }
                                            else if (Choix7 == 3)
                                            {
                                                //CHOIX 8 CI-DESSOUS

                                                //Affichage

                                                Console.WriteLine("Vous attaquez à la DeadPool et vous parvenez après plusieurs esquive à le toucher mais ses écailles sont trop dures. Vous reculez alors et courez dans la pièce en evitant les attaques du boss tout en pensant à une solution. Vous avez 1 minutes et 30 secondes pour trouver l'endroit(le point faible) où frapper afin de térasser la bête.");
                                                Console.WriteLine("Écrivez le nom de la partie du corp du dragon à frapper dessous:");

                                                //saise
                                                Choix8 = Console.ReadLine();

                                                if (Choix8.ToLower() == "ventre")
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Vous vous attaquerez alorsle ventre du dragon. vous vous glissez jusqu'a son immense ventre tout en évitant ses multiples attaques. Arrivé sous son ventre , vous courez et déchirrez le ventre de la bête en deux sous. Après un cri de mort démentiel, il s'éffondre! Vous montez directement niveau 10");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Félicitation vous avez terminé la béta du jeux. Vous pourez vous procurez le jeux jamais haha! Le jeux aurait compté 50 monde et 50 boss a tuée , dommage que ce ne sois qu'une béta ;) ");
                                                    Console.WriteLine("Crée par Nicolas Côté... FIN");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Vous n'avez pas saisie la bonne partie du corp à frapper, lors de votre essaie le dragon vous carbonise sur le champs. Vous mourrez. FIN.RECOMMENCEZ");
                                                }


                                            }
                                        }





                                    }
                                    else if (Choix3 == 2)
                                    {
                                        Console.WriteLine("Vous choissez de continuer votre route , mais comme l'enfant vous la dit , le mage réussie finalement afin a détruire le pays et vous avec , vous auriez dû l'arreter. FIN.RECOMMENCEZ");
                                    }




                                }




                            }








                        }
                        else if (Choix4 == 2)
                        {
                            Console.WriteLine("Alors que votre lame transperce le goblin, elle se bloque sur son armure épaise , votre lame est bloquée , il se retourne et vous tue de sa hache sans que vous puissez rien faire.FIN.RECOMMENCEZ");
                        }




                    }
                }

                //CHOIX 1 HUMAIINNNN

            }
            else if (ChoixRace == 2)
            {
                //Affichage
                Console.WriteLine("Vous choisisez la race des humains, vous apparaisez avec une lourde et tranchante lame, vous possédez une force incoryable et vous êtes résistant mais, vous êtes plutôt lent. Vous avez devant vous 2 portes en bois la première mène au Boss ou il est recommandé d'etre niveau 5 et la porte 2 mène dans le premier monde ou vous pourrez montez de niveau et vous procurez de l'équipement");
                Console.WriteLine("Vous devez choir:");
                Console.WriteLine("------------------------------------------------------------------------------------------");

                //CHOIX 2 CI-DESSOUS
                Console.WriteLine("Vous entrez dans la salle du boss(Appuyez sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Vous allez dans le monde 1 de SwordLordFantasy(Appuyez sur 2)");
                Console.WriteLine("");

                //saisie
                Choix2 = Convert.ToInt32(Console.ReadLine());

                if (Choix2 == 1)
                {
                    //Affichage
                    Console.WriteLine("Vous pénétrez dans la salle du boss, son enorme masse arrive sur vous cependant si la chance est de votre côté vous parviendrez à l'éviter");
                    Console.WriteLine("");
                    Random aleatoire = new Random();
                    Chance1 = aleatoire.Next(1, 11);

                    if (Chance1 >= 8)
                    {
                        //Afficahge
                        Console.WriteLine("Vous parvenez à évier la masse mais cependant sa corne vous transperce et vous mourrez.Recommencez votre Aventure en fermant et relancant l'application");
                    }

                    else if (Chance1 <= 7)
                    {
                        //Affichage
                        Console.WriteLine("Vous recevez la masse en pleine tête et vous mourrez. Fermez le programme et relancez le pour recommencer la partie ");
                    }

                }

                else if (Choix2 == 2)
                {

                    //CHOIX 3 CI-DESSOUS

                    //Affichage
                    Console.WriteLine("Vous allez dans le monde afin de prendre de l'exéprience, mais dès que vous apparaissez un goblin vous attaque par la droite.");
                    Console.WriteLine("Vous devez choisir");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("Vous tentez d'éviter le coup(Appuyez sur 1)");
                    Console.WriteLine("");
                    Console.WriteLine("Vous bloquez le coup avec votre lame(Appuyez sur 2)");
                    Console.WriteLine("");

                    //Saisie
                    Choix3 = Convert.ToInt32(Console.ReadLine());

                    if (Choix3 == 1)
                    {
                        //Affichage
                        Console.WriteLine("Vous essayez d'esquiver mais vous êtes trop lent , il vous touche et vous tue. Fin");
                    }
                    else if (Choix3 == 2)
                    {

                        //choix4 CI-DESSOUS

                        //Affichage
                        Console.WriteLine("Puisque vous êtes puissant vous parrez son coup et vous vous préaprez à contre attaquer.");
                        Console.WriteLine("Vous devez choisir:");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("lui transpercer le corp de votre lame(Appuyez sur 1)");
                        Console.WriteLine("");
                        Console.WriteLine("lui couper les tendons afin de l'achever plus facilement(Appuyez sur 2)");
                        Console.WriteLine("");


                        //Saisie
                        Choix4 = Convert.ToInt32(Console.ReadLine());

                        if (Choix4 == 1)
                        {
                            //Affichage
                            Console.WriteLine("Vous transpercez donc l'armur dun goblin et lui aussi et recevez alors de l'expérience");
                            Console.WriteLine(" ");
                            Random aleatoire = new Random();
                            Chance2 = aleatoire.Next(1, 3);
                            Console.WriteLine("vous recupérez alors " + Chance2 + " niveau(x)");

                            if (Chance2 == 1)
                            {
                                //CHOIX5 CI-DESSOUS

                                //Affichage

                                Console.WriteLine("");
                                Console.WriteLine("Vous gagnez donc un niveau et vous passez niveau 2. Vous marchez donc sur le chemin devant creuser dans la plaine dont la lune illumine de sa lumière la nuit. Vous arrivez devant une intersection ou il est recommandé pour les joueurs de niveau 2 d'aller a droite et ceux de niveau 3 d'aller a gauche. Vous allez donc a droite et après queques heures vous arrivez a un village calme jusqu'à ce qu'une femme pousse un crie de mort dans la ruelle marchande sur votre droite. ");
                                Console.WriteLine("Vous devez donc choisir:");
                                Console.WriteLine("------------------------------------------------------------------------------------------");
                                Console.WriteLine("Vous allez dans la ruelle voir ce qui se passe(Appuyez sur 1)");
                                Console.WriteLine("");
                                Console.WriteLine("Vous ignorez ce cris et continuez votre route(Appuyez sur 2)");
                                Console.WriteLine("");

                                //Saisie
                                Choix5 = Convert.ToInt32(Console.ReadLine());

                                //CHOIX6 CI-DESSOUS

                                //Affichage

                                if (Choix5 == 1)
                                {
                                    Console.WriteLine(" Vous accourez donc dans cette ruelle sombre, mais plus vous avancez plus un brouillard épais apparait... Il n'y a personne vous vous retournez mais trop tard , vous sentez un lame froide vous coupez la gorge, vous n'avez rien pus faire, vous n'avez rien pus faire, vous n'avez rien pus voir. FIN.RECOMMENCEZ");

                                }
                                else if (Choix5 == 2)
                                {
                                    Console.WriteLine("Votre tempérament indiférent vous à été favorable cette fois-ci, une créature (surment celle qui à tentez de vous appater dans cette ruelle) sort du brouillard que contenait cette ruelle et se tire sur vous avec une vitesse étonnante mais vous avez le temps de parer l'attaque ce qui n'aurait pas été le cas dans cette ruelle, elle reviens alors a la charge . ");
                                    Console.WriteLine("Vous dez alors choisir:");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    Console.WriteLine(" Vous évitez le coup afin de contre-attaquer(Appyez sur 1)");
                                    Console.WriteLine("");
                                    Console.WriteLine("Vous parez le coups (appuyez sur 2)");

                                    //Saisie
                                    Choix6 = Convert.ToInt32(Console.ReadLine());

                                    //Afficahge

                                    //CHOIX 7 CI-DESSOUS

                                    if (Choix6 == 1)
                                    {
                                        Console.WriteLine("La créature qui a constaté votre force et regardé votre précédent combat anticipe une parade de votre part, vise vos jambes et frappe dans le vide puisque vous esquivez , Vous tuez donc la créature désorientée. Vous avez tué la créature et passez niveau 5 , un portail souvre alors celui ou se trouve le boss de ce monde. vous êtes aspiré par ce portail... ");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous reprenez vos esprtis quelques instant plus tard dans la salle de ce boss. Le boss se tien devant vous. C'est un immense dragon. Ils vous regarde et en un istant c'est hp apparaissent au-dessus de lui. il possède 100hp");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous devez réfléchir à un plan de match afin de vaincre ce boss, 3 option s'offre a vous: ");
                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("vous bloquez afin de voir qu'elle est sa puissance de frappe(appuyez sur 1)");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous attaquez avant lui pour ensuite esquiver(appuyez sur 2)");
                                        Console.WriteLine("");
                                        Console.WriteLine("vous foncer sur le dragon à la facon DeadPool afin de L'attaquer tout en parant les attaques(appuyez sur 3)");
                                        Console.WriteLine("");

                                        //Saisie
                                        Choix7 = Convert.ToInt32(Console.ReadLine());

                                        if (Choix7 == 1)
                                        {
                                            Console.WriteLine("Êtes-vous cinglé ? comment avez vous pus penser bloquer le feu d'un dragon avec une simple lame? Vous mourrez d'attroce souffrances dans les flammes du dragon. FIN. RECOMMENCEZ");
                                        }
                                        else if (Choix7 == 2)
                                        {
                                            Console.WriteLine("Tentez-vous sérieusement de prendre un boss de vitesse? LE boss réagis très mal a votre attaque vous contre avec ses griffes meurtrière et vous tue. FIN. RECOMMENCEZ");
                                        }
                                        else if (Choix7 == 3)
                                        {
                                            //CHOIX 8 CI-DESSOUS

                                            //Affichage

                                            Console.WriteLine("Vous attaquez à la DeadPool et vous parvenez après plusieurs parrades à le toucher mais ses écaille sont trop dures. Vous reculez alors et courez dans la pièce en evitant les attaques du boss tout en pensant à une solution. Vous avez 1 minutes et 30 secondes pour trouver l'endroit(le point faible) où frapper afin de térasser la bête.");
                                            Console.WriteLine("Écrivez le nom de la partie du corp du dragon à frapper dessous:");

                                            //saise
                                            Choix8 = Console.ReadLine();

                                            if (Choix8.ToLower() == "ventre")
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("Vous vous attaquez alors au ventre du dragon , apr`s avoir subît de lourd déga^t afin de s'en approcher,  vous vous retrouvez finalement sous son ventre et déchirrez son ventre en 2, la bête s'éffondre! Vous montez directement niveau 10");
                                                Console.WriteLine("");
                                                Console.WriteLine("Félicitation vous avez terminé la béta du jeux. Vous pourez vous procurez le jeux jamais haha! Le jeux aurait compté 50 monde et 50 boss a tuée , dommage que ce ne sois qu'une béta ;) ");
                                                Console.WriteLine("Crée par Nicolas Côté... FIN");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Vous n'avez pas saisie la bonne partie du corp à frapper, lors de votre essaie le dragon vous carbonise sur le champs. Vous mourrez. FIN");
                                            }

                                        }


                                    }
                                    else if (Choix6 == 2)
                                    {
                                        Console.WriteLine("La créature à enticipé votre parade et parvient a vous trancher les jambes et ensuite la gorge de sa froide dague . Vous mourrez. FIN. RECOMMENCEZ");

                                    }



                                }

                            }
                            else if (Chance2 == 2)
                            {

                                //CHOIX 5 CI-DESSOUS

                                //Affichage
                                Console.WriteLine("Vous gagnez donc deux niveau et vous passez niveau 3. Vous marchez donc sur le chemin devant creusé dans les plaines dont la lune illumine de sa lumière la nuit. Vous arrivez devant une intersection ou il est rcommander pour les joueurs de niveau 2 d'aller a droite et ceux de niveau 3 d'aller a gauche. Vous allez donc a gauche et après quelques minutes de marche vous arrivez dans un village ou il n'y a personne, ny même un bruit.");
                                Console.WriteLine("");
                                Console.WriteLine(" Plus vous pénétrez dans le village et plus vous entendez des cris , des hurlement de souffrances.. Tous vienne d'un endroit , cet eglise située au millieu de cet étrange village, vous devez choisir");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Vous entrez dans l'église par la porte principale afin de voir se qui s'y passe (Appuyez sur 1)");
                                Console.WriteLine("");
                                Console.WriteLine(" Vous attendez que quelqu'un sorte afin de ne pas vous mettre en danger (Appuyez sur 2)");
                                Console.WriteLine("");
                                Console.WriteLine("Vous essayez de quitter la zone (appuyez sur 3) ");
                                Console.WriteLine("");

                                //Saisie ( HEY je me suis rendu compte que l'on peu mettre choix (1-2-3-...)car il est deja utilisé :D
                                Choix2 = Convert.ToInt32(Console.ReadLine());

                                if (Choix2 == 1)
                                {
                                    Console.WriteLine("Vous entrez dans l'église,et ce que vous appercevez est tout bonnement horrible, une centaine de personne se tiens à l'intérieur d'un énorme cercle magique ou leurs énergie vitale est absorbée.");
                                    Console.WriteLine("Vous arrivez cepedant au mauvais moment et vous êtes aspiré par ce cercle...  une fois dedans impossbile d'en sortir ou dele briser de l'intérieur. Vous mourrez. FIN");
                                }
                                else if (Choix2 == 2)
                                {
                                    Console.WriteLine("Vous attendez et voyez un jeune mage au yeux mauves sortir enfin , il vous appercois et vous lance un sort si immense qu'il est impossible à éviter , vous tentez de parer mais la magie transperce votre arme et vous tue . FIN");

                                }
                                else if (Choix2 == 3)
                                {
                                    //Choix 6 CI-DESSOUS

                                    //Affichage

                                    Console.WriteLine("Vous tentez de quitter la zone mais sur le chemin vous rencontrez un enfants qui s'était visiblement caché, il vous raconte alors qu'un mage noir et puissant est arrivé en ville aujourd'hui et pratique sur les villagois de la magie noir afin de détruire le pays entier");
                                    Console.WriteLine("");
                                    Console.WriteLine("L'enfant vous supplies de l'aider , Vous devez Choisir:");
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Vous décicez d'aider l'enfant ( Appuyez sur 1)");
                                    Console.WriteLine("");
                                    Console.WriteLine("Vous continuez votre route ( Appuyez sur 2)");
                                    Console.WriteLine("");

                                    //Saisie
                                    Choix3 = Convert.ToInt32(Console.ReadLine());

                                    if (Choix3 == 1)
                                    {
                                        //Affichge

                                        //Choix 7 CI-DESSOUS
                                        Console.WriteLine("Vous dites donc à l'enfant que vous arretez ce mage. L'enfant vous expliqua que le mage n'a pas pus s'attaquer a lui car il possédait une amulette anti-magie. Il vous fit cadeau de son amulette qe vous accrochez directement a votre épée.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous foncez donc à l'église mais une fois arrivé, plus aucun bruit , seulement le mage qui attendais votre arrivé se tenait debout. Les habitants étais tous évanouie , au seuil de la mort.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Le mage vous attaque avec une boule de magie énormemais vous la désintégrez facielement avec votre épée équipée de son amulette.Vous foncez sur lui épé à la main en brisant sa magie. Vous le meacez mainteant de votre épé");
                                        Console.WriteLine("Vous devez choisir :");
                                        Console.WriteLine("----------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("Vous lui laissez la vie et lui forcé a rendre l'énergie a tout le monde (appuyez sur 1)");
                                        Console.WriteLine("");
                                        Console.WriteLine("Vous lui tranchez la gorge (Appuyez sur 2)");
                                        //Saisie

                                        Choix4 = Convert.ToInt32(Console.ReadLine());

                                        if (Choix4 == 1)
                                        {
                                            Console.WriteLine(" Vous retirez votre épée de sa gorge mais si tôt fait il vous transperca d'une lame que vous aviez jamais remarqué. Votre coeur est touché . FIN. RECOMMENCEZ");
                                        }
                                        else if (Choix4 == 2)
                                        {
                                            Console.WriteLine("Au moment ou vous lui tranchez la gorge , il vous transperca d'une lame que vous aviez jamais remarqué. Aucune zone vitale est touchée mais vous vous évanouissez alors qu'il meurt. ");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous montez niveau 5");
                                            Console.WriteLine("Vous vous réveillez dans une maison entouré des villagois et de l'enfant. pour vous remercié ceux-ci vous ont soigné et vous donne une clé que dès que vous prendrez en main vous serez téléporté en face du boss du niveau 1 de ce jeu ");
                                            Console.WriteLine("Vous remerciez les villagois et prenez la clé en main. Elle s'évapore de si tôt. Un portail souvre et vous êtes asprié dedans");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous reprenez vos esprtis quelques instant plus tard dans la salle de ce boss. Le boss se tien devant vous. C'est un immense dragon. Ils vous regarde et en un istant c'est hp apparaissent au-dessus de lui. il possède 100hp");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous devez réfléchir à un plan de match afin de vaincre ce boss, 3 option s'offre a vous: ");
                                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                            Console.WriteLine("vous bloquez afin de voir qu'elle est sa puissance de frappe(appuyez sur 1)");
                                            Console.WriteLine("");
                                            Console.WriteLine("Vous attaquez avant lui pour ensuite esquiver(appuyez sur 2)");
                                            Console.WriteLine("");
                                            Console.WriteLine("vous foncer sur le dragon à la facon DeadPool afin de L'attaquer tout en parant les attaques(appuyez sur 3)");
                                            Console.WriteLine("");

                                            //Saisie
                                            Choix7 = Convert.ToInt32(Console.ReadLine());

                                            if (Choix7 == 1)
                                            {
                                                Console.WriteLine("Êtes-vous cinglé ? comment avez vous pus penser bloquer le feu d'un dragon avec une simple lame? Vous mourrez d'attroce souffrances dans les flammes du dragon. FIN. RECOMMENCEZ");
                                            }
                                            else if (Choix7 == 2)
                                            {
                                                Console.WriteLine("Tentez-vous sérieusement de prendre un boss de vitesse? LE boss réagis très mal a votre attaque vous contre avec ses griffes meurtrière et vous tue. FIN. RECOMMENCEZ");
                                            }
                                            else if (Choix7 == 3)
                                            {
                                                //CHOIX 8 CI-DESSOUS

                                                //Affichage

                                                Console.WriteLine("Vous attaquez à la DeadPool et vous parvenez après plusieurs parades à le toucher mais ses écaille sont trop dures. Vous reculez alors et courez dans la pièce en evitant les attaques du boss tout en pensant à une solution. Vous avez 1 minutes et 30 secondes pour trouver l'endroit(le point faible) où frapper afin de térasser la bête.");
                                                Console.WriteLine("Écrivez le nom de la partie du corp du dragon à frapper dessous:");

                                                //saise
                                                Choix8 = Console.ReadLine();

                                                if (Choix8.ToLower().Equals("ventre"))
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Vous vous attaquez alors au ventre du dragon , apr`s avoir subît de lourd déga^t afin de s'en approcher,  vous vous retrouvez finalement sous son ventre et déchirrez son ventre en 2, la bête s'éffondre! Vous montez directement niveau 10");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Félicitation vous avez terminé la béta du jeux. Vous pourez vous procurez le jeux jamais haha! Le jeux aurait compté 50 monde et 50 boss a tuée , dommage que ce ne sois qu'une béta ;) ");
                                                    Console.WriteLine("Crée par Nicolas Côté... FIN");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Vous n'avez pas saisie la bonne partie du corp à frapper, lors de votre essaie le dragon vous carbonise sur le champs. Vous mourrez. FIN.RECOMMENCEZ");
                                                }


                                            }
                                        }





                                    }
                                    else if (Choix3 == 2)
                                    {
                                        Console.WriteLine("Vous choissez de continuer votre route , mais comme l'enfant vous la dit , le mage réussie finalement afin a détruire le pays et vous avec , vous auriez dû l'arreter. FIN.RECOMMENCEZ");
                                    }




                                }




                            }








                        }
                        else if (Choix4 == 2)
                        {
                            Console.WriteLine("Vous tentez d'esquiver l'attaque du goblin , mais vous n'êtes pas assez rapide, vous mourrez . FIN.RECOMMENCEZ");
                        }




                    }
                }


            }
            Console.ReadKey();






        }

    }
}
