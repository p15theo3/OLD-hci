#Τίτλος Εργασίας: Fusion Tables Tool for SocialSkip

##Παραδοτέο 1
Κατασκευή εργαλείου για το SocialSkip το οποίο θα αυτοματοποιεί την αρχικοποίηση της βάσης δεδομένων του (Fusion Tables)

##Παραδοτέο 2

###Περιγραφή
Ένα εργαλείο γραμμένο σε γλώσσα Java το οποίο δημιουργεί αυτόματα τους πίνακες στο Fusion Tables της Google που χρειάζονται για την λειτουργία του SocialSkip. Με κλήσεις στο REST API του Fusion Tables αρχικοποιείται για κάθε πίνακα το σχήμα και έπειτα εισάγεται στην βάση δεδομένων του χρήστη.

###Εργαλεία: 
Java, Fusion Tables Java API

###Κώδικας 
https://github.com/vidoodlics/fusion-tables-tool

###Οδηγίες Εγκατάστασης
1. Δημιουργούμε ένα JSON κλειδί όπως περιγράφουν οι επίσημες οδηγίες εδώ https://developers.google.com/maps/documentation/javascript/get-api-key
2. Ονομάζουμε το αρχείο key.json και το τοποθετούμε στον φάκελο src/main/resources
3. Δημιουργούμε το πλέον αρχικοποιημένο conf.xml αρχείο εκτελώντας: `./bin/init.sh`
