using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalApp.Components.Models;

namespace AnimalApp.Components.Data
{
    public class AnimalDataSeeder
    {
        private readonly AnimalAppContext _db;

        public AnimalDataSeeder(AnimalAppContext db)
        {
            _db = db;
        }

        public void SeedClassData()
        {
            if (!_db.AnimalClasses.Any())
            {
                _db.AnimalClasses.AddRange(new List<AnimalClass>
        {
            new AnimalClass { Name = "Mammal", IsWarmBlooded = true, MethodOfReproduction = "Live Birth" },
            new AnimalClass { Name = "Bird", IsWarmBlooded = true, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Reptile", IsWarmBlooded = false, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Amphibian", IsWarmBlooded = false, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Insect", IsWarmBlooded = false, MethodOfReproduction = "Egg" }
        });

                _db.SaveChanges(); // Persist changes to database
            }
        }

        public void SeedAnimaldata()
        {
            var mammalClass = _db.AnimalClasses.FirstOrDefault(c => c.Name == "Mammal");
            var birdClass = _db.AnimalClasses.FirstOrDefault(c => c.Name == "Bird");
            var reptileClass = _db.AnimalClasses.FirstOrDefault(c => c.Name == "Reptile");
            var amphibianClass = _db.AnimalClasses.FirstOrDefault(c => c.Name == "Amphibian");
            var insectClass = _db.AnimalClasses.FirstOrDefault(c => c.Name == "Insect");

            if (!_db.Animals.Any())
            {
                _db.Animals.AddRange(new List<Animal>
                {
                    new Animal {
                        Name = "Addax",
                        AnimalClass = mammalClass,
                        Description = "The Addax is a large antelope native to the Sahara Desert. It is well-adapted to living in extreme desert conditions.",
                        Diet = "Herbivore, primarily feeds on grasses, leaves, and shrubs.",
                        Colors = new List<string> { "White", "Light brown" },
                        Weight = 100,
                        NativeLocation = "Sahara Desert, North Africa",
                        Facts = new List<string>
                        {
                            "Addax can survive without drinking water for long periods, obtaining moisture from plants.",
                            "It is critically endangered due to habitat loss and hunting."
                        }
                    },
                    new Animal
                    {
                        Name = "Alligator, American",
                        AnimalClass = reptileClass,
                        Description = "The American Alligator is a large reptile found primarily in the southeastern United States. It is known for its powerful bite and is an apex predator in its ecosystem.",
                        Diet = "Carnivorous, primarily feeds on fish, birds, and mammals.",
                        Colors = new List<string> { "Dark green", "Black", "Light undersides" },
                        Weight = 400,
                        NativeLocation = "Southeastern United States (Florida, Louisiana, Alabama, etc.)",
                        Facts = new List<string>
                        {
                            "American Alligators are the largest species of alligator.",
                            "They can live up to 35-50 years in the wild.",
                            "They are known for their powerful bite and can take down large prey.",
                            "American Alligators are cold-blooded, meaning their body temperature depends on their environment."
                        }
                    },
                    new Animal
                    {
                        Name = "Alligator, Chinese",
                        AnimalClass = reptileClass,
                        Description = "The Chinese Alligator is a small species of alligator found in the Yangtze River basin in China. It is critically endangered due to habitat destruction and hunting.",
                        Diet = "Carnivorous, primarily feeds on fish, birds, and amphibians.",
                        Colors = new List<string> { "Black", "Dark brown", "Light underbelly" },
                        Weight = 36,
                        NativeLocation = "Yangtze River basin, China",
                        Facts = new List<string>
                        {
                            "Chinese Alligators are much smaller than their American counterparts, with males typically reaching only 2 meters in length.",
                            "This species is critically endangered, with only a few hundred individuals remaining in the wild.",
                            "They are nocturnal and spend much of their time in freshwater swamps and ponds.",
                            "Chinese Alligators have a unique behavior where they burrow into the mud to survive colder temperatures during winter."
                        }
                    },
                    new Animal
                    {
                        Name = "Anaconda",
                        AnimalClass = reptileClass,
                        Description = "Anacondas are large, non-venomous snakes found in South America. They are among the heaviest and longest snakes in the world.",
                        Diet = "Carnivorous, primarily preys on fish, birds, mammals, and sometimes caimans and capybaras.",
                        Colors = new List<string> { "Olive green", "Yellowish", "Black spots" },
                        Weight = 250,
                        NativeLocation = "South America (Amazon and Orinoco basins)",
                        Facts = new List<string>
                        {
                            "The Green Anaconda is the largest snake in the world by weight and one of the longest.",
                            "Anacondas are constrictors, meaning they kill their prey by wrapping around it and squeezing until it suffocates.",
                            "They are semi-aquatic, spending much of their time in water, where they are excellent swimmers.",
                            "Despite their large size, anacondas are capable of hunting prey as large as caimans and capybaras."
                        }
                    },

                    new Animal
                    {
                        Name = "Armadillo, Southern Three-Banded",
                        AnimalClass = mammalClass,
                        Description = "The Southern Three-Banded Armadillo is a species of armadillo found in central and southern Brazil, Paraguay, and Argentina. It is known for its ability to roll into a ball for protection.",
                        Diet = "Insectivorous, feeds mainly on insects, small invertebrates, and plants.",
                        Colors = new List<string> { "Gray", "Light brown" },
                        Weight = 1.5,
                        NativeLocation = "Brazil, Paraguay, Argentina",
                        Facts = new List<string>
                        {
                            "This species of armadillo is known for its distinctive three bands on its armor and its unique ability to curl into a tight ball to defend itself.",
                            "It is one of the few armadillos capable of completely rolling into a ball, making it difficult for predators to attack.",
                            "The Southern Three-Banded Armadillo is nocturnal and prefers dry, open areas such as savannas and grasslands."
                        }
                    },

                    new Animal
                    {
                        Name = "Babirusa",
                        AnimalClass = mammalClass,
                        Description = "The Babirusa is a species of wild pig native to the Indonesian islands of Sulawesi, Togian, and Sula. It is known for its distinctive upward-curving tusks.",
                        Diet = "Omnivorous, feeds on roots, fruits, and small animals.",
                        Colors = new List<string> { "Gray", "Brown" },
                        Weight = 90,
                        NativeLocation = "Sulawesi, Togian Islands, Sula Islands (Indonesia)",
                        Facts = new List<string>
                        {
                            "The Babirusa is one of the most endangered species of wild pig due to habitat loss and hunting.",
                            "Male babirusas have large, spiral tusks that grow upwards from their upper jaw and can even penetrate their own face.",
                            "Babirusas are forest dwellers, often found in dense tropical forests and swamps."
                        }
                    },

                    new Animal
                    {
                        Name = "Bat, Rodrigues Fruit",
                        AnimalClass = mammalClass,
                        Description = "The Rodrigues Fruit Bat, also known as the Rodrigues Flying Fox, is a species of megabat found only on Rodrigues Island in the Indian Ocean. It is known for its large size and fruit-based diet.",
                        Diet = "Frugivorous, primarily feeds on fruit, nectar, and flowers.",
                        Colors = new List<string> { "Dark brown", "Black" },
                        Weight = 0.15,
                        NativeLocation = "Rodrigues Island (Mauritius)",
                        Facts = new List<string>
                        {
                            "The Rodrigues Fruit Bat is critically endangered due to habitat loss, hunting, and the introduction of non-native predators.",
                            "It has a wingspan of up to 1 meter and is one of the largest bat species in the world.",
                            "Conservation efforts have helped stabilize its population, but it is still considered one of the rarest bats."
                        }
                    },

                    new Animal
                    {
                        Name = "Bat, Vampire",
                        AnimalClass = mammalClass,
                        Description = "The Vampire Bat is a species of bat native to Central and South America, known for feeding on the blood of mammals and birds.",
                        Diet = "Carnivorous, feeds on the blood of mammals and birds.",
                        Colors = new List<string> { "Brown", "Gray" },
                        Weight = 0.06,
                        NativeLocation = "Central and South America",
                        Facts = new List<string>
                        {
                            "Vampire bats have heat sensors on their nose to locate blood vessels on their prey.",
                            "They are the only mammals that feed exclusively on blood.",
                            "Vampire bats use their sharp teeth to make a small incision in their prey's skin, allowing them to lap up the blood."
                        }
                    },

                    new Animal
                    {
                        Name = "Bear, Brown",
                        AnimalClass = mammalClass,
                        Description = "The Brown Bear is a large bear species found in North America, Europe, and Asia, known for its massive size and omnivorous diet.",
                        Diet = "Omnivorous, feeds on a wide variety of foods including plants, berries, fish, and small mammals.",
                        Colors = new List<string> { "Brown", "Tan" },
                        Weight = 600,
                        NativeLocation = "North America, Europe, Asia",
                        Facts = new List<string>
                        {
                            "Brown bears are capable of reaching speeds of up to 35 miles per hour despite their large size.",
                            "They are known for their hibernation during the winter months, during which they live off their fat reserves.",
                            "Brown bears are solitary animals, except during mating season or when a mother is with her cubs."
                        }
                    },

                    new Animal
                    {
                        Name = "Bear, Polar",
                        AnimalClass = mammalClass,
                        Description = "The Polar Bear is a large bear species found in the Arctic region, well-adapted to cold environments and primarily feeds on seals.",
                        Diet = "Carnivorous, primarily hunts seals, but will also scavenge or eat other animals when necessary.",
                        Colors = new List<string> { "White", "Cream" },
                        Weight = 450,
                        NativeLocation = "Arctic region",
                        Facts = new List<string>
                        {
                            "Polar bears have thick fur and a layer of fat to insulate them from the extreme cold.",
                            "They are excellent swimmers, often traveling long distances in search of food.",
                            "Due to climate change and melting sea ice, polar bear populations are under threat as they rely on ice for hunting."
                        }
                    },

                    new Animal
                    {
                        Name = "Bearded Dragon",
                        AnimalClass = reptileClass,
                        Description = "The Bearded Dragon is a species of lizard native to Australia, known for its spiny 'beard' under its chin and calm temperament.",
                        Diet = "Omnivorous, feeding on a mix of insects, fruits, and vegetables.",
                        Colors = new List<string> { "Tan", "Brown", "Orange" },
                        Weight = 0.5,
                        NativeLocation = "Australia",
                        Facts = new List<string>
                        {
                            "Bearded Dragons are known for their distinctive beard-like flap of skin under their chin, which they puff out when threatened.",
                            "They are social and enjoy interaction with humans, making them popular pets.",
                            "They can regulate their body temperature by basking in the sun or seeking shade."
                        }
                    },

                    new Animal
                    {
                        Name = "Bongo",
                        AnimalClass = mammalClass,
                        Description = "The Bongo is a large antelope found in the rainforests of Central and West Africa, characterized by its striking orange-brown coat with white stripes.",
                        Diet = "Herbivore, feeds on leaves, fruits, and shoots.",
                        Colors = new List<string> { "Orange-brown", "White" },
                        Weight = 400,
                        NativeLocation = "Central and West Africa",
                        Facts = new List<string>
                        {
                            "Bongos are nocturnal and tend to stay in dense forests to avoid predators.",
                            "They are known for their long, spiral horns, which are used for defense against predators.",
                            "Bongos are an endangered species due to habitat loss and hunting for their meat and horns."
                        }
                    },

                    new Animal
                    {
                        Name = "Camel, Dromedary",
                        AnimalClass = mammalClass,
                        Description = "The Dromedary Camel is a large mammal with one hump, adapted to survive in hot, arid environments like deserts.",
                        Diet = "Herbivore, feeds on grasses, shrubs, and cacti.",
                        Colors = new List<string> { "Light brown", "Tan", "Beige" },
                        Weight = 600,
                        NativeLocation = "Middle East, North Africa, and parts of Asia",
                        Facts = new List<string>
                        {
                            "Dromedary camels are well-known for their ability to go without water for long periods, relying on their fat reserves in their hump.",
                            "They are used as pack animals and for transportation in desert regions.",
                            "Their thick fur helps to protect them from the sun, and their hooves are specially adapted for walking on sand."
                        }
                    },
                    new Animal
                    {
                        Name = "Cardinal, Red-capped",
                        AnimalClass = birdClass,
                        Description = "The Red-capped Cardinal is a small songbird native to South America, known for its striking red cap and black body.",
                        Diet = "Omnivorous, feeding on seeds, fruits, and small insects.",
                        Colors = new List<string> { "Red", "Black", "White" },
                        Weight = 0.03,
                        NativeLocation = "South America, particularly in Argentina, Brazil, and Uruguay",
                        Facts = new List<string>
                        {
                            "The Red-capped Cardinal is known for its beautiful song, often heard in forested areas and gardens.",
                            "Males are more colorful, with bright red on their heads, while females have more muted tones.",
                            "This bird is often kept as a pet in some parts of the world due to its vibrant colors and melodic calls."
                        }
                    },

                    new Animal
                    {
                        Name = "Cardinal, Red-crested",
                        AnimalClass = birdClass,
                        Description = "The Red-crested Cardinal is a colorful bird with a striking red crest and a contrasting black and white body, native to South America.",
                        Diet = "Omnivorous, consuming seeds, fruits, and insects.",
                        Colors = new List<string> { "Red", "Black", "White" },
                        Weight = 0.05,
                        NativeLocation = "South America, primarily found in Brazil, Paraguay, and Argentina",
                        Facts = new List<string>
                        {
                            "The Red-crested Cardinal is easily identifiable by its bright red crest and black-and-white plumage.",
                            "It is often seen in gardens, forests, and parks, where it feeds on seeds and fruits.",
                            "This bird has a melodious song, which is part of its courtship display."
                        }
                    },

                    new Animal
                    {
                        Name = "Chameleon, Panther",
                        AnimalClass = reptileClass,
                        Description = "The Panther Chameleon is a species of chameleon found in Madagascar, known for its vibrant colors and the ability to change hue.",
                        Diet = "Insectivore, feeding on a variety of insects such as crickets, grasshoppers, and locusts.",
                        Colors = new List<string> { "Green", "Blue", "Red", "Yellow" },
                        Weight = 0.2,
                        NativeLocation = "Madagascar",
                        Facts = new List<string>
                        {
                            "Panther chameleons are famous for their ability to change color based on temperature, mood, and environmental factors.",
                            "The males are more brightly colored, with intense hues of blue, red, and green.",
                            "They are arboreal, living in trees and shrubs, and use their prehensile tail for gripping branches."
                        }
                    },

                    new Animal
                    {
                        Name = "Chinchilla",
                        AnimalClass = mammalClass,
                        Description = "The Chinchilla is a small, nocturnal rodent known for its incredibly soft fur, native to the Andes mountains of South America.",
                        Diet = "Herbivore, feeding primarily on grasses, seeds, and plants.",
                        Colors = new List<string> { "Gray", "Black", "White" },
                        Weight = 0.4,
                        NativeLocation = "Andes Mountains, South America",
                        Facts = new List<string>
                        {
                            "Chinchillas have the densest fur of any land mammal, with up to 60 hairs growing from each follicle.",
                            "Due to their sensitive skin, they require regular dust baths to maintain their fur.",
                            "Chinchillas are social animals and thrive in pairs or small groups in the wild."
                        }
                    },

                    new Animal
                    {
                        Name = "Crane, East African Crowned",
                        AnimalClass = birdClass,
                        Description = "The East African Crowned Crane is a large, elegant bird known for its striking golden crest and vibrant plumage.",
                        Diet = "Omnivorous, feeding on grasses, seeds, small invertebrates, and insects.",
                        Colors = new List<string> { "Gray", "White", "Yellow", "Black" },
                        Weight = 3.5,
                        NativeLocation = "East Africa, including countries like Kenya, Uganda, and Tanzania",
                        Facts = new List<string>
                        {
                            "The East African Crowned Crane is a symbol of Uganda and is known for its elaborate courtship dance.",
                            "Its large, golden crown of feathers makes it one of the most recognizable crane species.",
                            "The crane's diet varies depending on the season, and it is often found near wetlands and marshes."
                        }
                    },

                    new Animal
                    {
                        Name = "Crane, Red-Crowned",
                        AnimalClass = birdClass,
                        Description = "The Red-Crowned Crane is a majestic bird with striking white plumage and a red patch on its head, symbolizing longevity and good fortune in East Asia.",
                        Diet = "Omnivorous, feeding on plants, seeds, insects, and small fish.",
                        Colors = new List<string> { "White", "Black", "Red" },
                        Weight = 7.5,
                        NativeLocation = "East Asia, primarily found in Japan, China, and Korea",
                        Facts = new List<string>
                        {
                            "Red-Crowned Cranes are one of the rarest and most endangered crane species in the world.",
                            "In Japan, they are considered a symbol of fidelity and are often associated with marriage ceremonies.",
                            "These cranes are known for their elegant, synchronized dancing, which is part of their courtship ritual."
                        }
                    },

                    new Animal
                    {
                        Name = "Crane, Wattled",
                        AnimalClass = birdClass,
                        Description = "The Wattled Crane is a large, striking bird known for the unique wattles hanging from its cheeks and its long legs.",
                        Diet = "Omnivorous, feeding on roots, tubers, seeds, and invertebrates.",
                        Colors = new List<string> { "Gray", "White", "Black", "Red" },
                        Weight = 6,
                        NativeLocation = "Sub-Saharan Africa, particularly in wetlands of South Africa, Zambia, and Mozambique",
                        Facts = new List<string>
                        {
                            "The Wattled Crane is one of the largest species of crane, characterized by its distinctive red wattle.",
                            "These cranes are usually found in pairs or small groups and are most often seen in wetlands and grasslands.",
                            "The Wattled Crane is considered a vulnerable species due to habitat loss and human disturbance."
                        }
                    },

                    new Animal
                    {
                        Name = "Crocodile, Cuban",
                        AnimalClass = reptileClass,
                        Description = "The Cuban Crocodile is a small but aggressive species of crocodile found in Cuba, known for its distinctive yellowish-green color and strong territorial behavior.",
                        Diet = "Carnivorous, primarily feeding on fish, birds, and small mammals.",
                        Colors = new List<string> { "Green", "Brown", "Yellow" },
                        Weight = 200,
                        NativeLocation = "Cuba, particularly in Zapata Swamp and Isla de la Juventud",
                        Facts = new List<string>
                        {
                            "The Cuban Crocodile is one of the smallest species of crocodile, typically growing to about 3-4 meters in length.",
                            "This species is known for its incredible agility, both on land and in water.",
                            "Cuban Crocodiles are critically endangered due to habitat loss, hunting, and hybridization with American Crocodiles."
                        }
                    },

                    new Animal
                    {
                        Name = "Dove, Beautiful Fruit",
                        AnimalClass = birdClass,
                        Description = "The Beautiful Fruit Dove is a vibrant, colorful bird native to the tropical forests of Southeast Asia, known for its striking plumage.",
                        Diet = "Fruitarian, primarily feeding on various fruits, berries, and seeds.",
                        Colors = new List<string> { "Green", "Red", "Purple", "Yellow" },
                        Weight = 0.3,
                        NativeLocation = "Southeast Asia, particularly in Malaysia, Indonesia, and the Philippines",
                        Facts = new List<string>
                        {
                            "The Beautiful Fruit Dove is prized for its brilliant and colorful plumage, which is often seen in vibrant shades of green and red.",
                            "This dove prefers dense tropical forests and is typically found in the canopy layers where it feeds on fruits and seeds.",
                            "The species is not currently considered endangered, but habitat loss poses a potential threat."
                        }
                    },
                    new Animal
                    {
                        Name = "Dove, Grey-capped Emerald",
                        AnimalClass = birdClass,
                        Description = "The Grey-capped Emerald Dove is a small, colorful bird native to the rainforests of Southeast Asia, recognized by its distinct grey cap and greenish plumage.",
                        Diet = "Omnivorous, feeding on seeds, fruits, and occasionally small invertebrates.",
                        Colors = new List<string> { "Green", "Gray", "Purple" },
                        Weight = 0.2,
                        NativeLocation = "Southeast Asia, particularly in Thailand, Myanmar, and Cambodia",
                        Facts = new List<string>
                        {
                            "The Grey-capped Emerald Dove is a quiet and elusive bird that typically inhabits dense forests and forest edges.",
                            "It is primarily frugivorous, but also feeds on seeds and small invertebrates found on the forest floor.",
                            "While not considered endangered, habitat loss and hunting are potential threats to its population."
                        }
                    },

                    new Animal
                    {
                        Name = "Dove, Mariana Fruit",
                        AnimalClass = birdClass,
                        Description = "The Mariana Fruit Dove is a small, vibrant bird native to the Mariana Islands, known for its colorful plumage and frugivorous diet.",
                        Diet = "Frugivorous, primarily feeding on a variety of fruits and berries found in its tropical habitat.",
                        Colors = new List<string> { "Green", "Pink", "Blue", "Yellow" },
                        Weight = 0.25,
                        NativeLocation = "Mariana Islands, particularly on Guam and Saipan",
                        Facts = new List<string>
                        {
                            "The Mariana Fruit Dove is known for its bright and colorful plumage, which includes vivid shades of green, pink, and blue.",
                            "It is a forest-dwelling bird that plays an important role in seed dispersal within its native habitat.",
                            "The species is considered vulnerable due to habitat destruction and predation by non-native species."
                        }
                    },
                    new Animal
                    {
                        Name = "Eagle, Bald",
                        AnimalClass = birdClass,
                        Description = "The Bald Eagle is a large bird of prey found in North America, known for its white head and tail and powerful hunting abilities.",
                        Diet = "Carnivorous, primarily feeding on fish, but will also eat birds, small mammals, and carrion.",
                        Colors = new List<string> { "Brown", "White", "Yellow" },
                        Weight = 3.6,
                        NativeLocation = "North America, particularly in the United States and Canada",
                        Facts = new List<string>
                        {
                            "The Bald Eagle is the national bird and symbol of the United States.",
                            "It is a skilled hunter with exceptional eyesight, capable of spotting prey from a great distance.",
                            "Bald Eagles primarily nest near large bodies of water to access an abundant food supply."
                        }
                    },
                    new Animal
                    {
                        Name = "Eagle, Steller's Sea",
                        AnimalClass = birdClass,
                        Description = "Steller's Sea Eagle is a large, powerful bird of prey found primarily along the coastlines of eastern Russia and parts of Japan.",
                        Diet = "Carnivorous, primarily feeding on fish, particularly salmon, as well as seabirds and carrion.",
                        Colors = new List<string> { "Dark brown", "White", "Yellow" },
                        Weight = 6.3,
                        NativeLocation = "Coastal areas of eastern Russia, Japan, and Korea",
                        Facts = new List<string>
                        {
                            "Steller's Sea Eagle is one of the largest eagles in the world, with impressive wingspans of up to 2.5 meters.",
                            "Its diet primarily consists of fish, making it highly dependent on healthy marine ecosystems.",
                            "The species is considered to be near-threatened due to habitat loss and overfishing in its range."
                        }
                    },
                    new Animal
                    {
                        Name = "Elephant, African",
                        AnimalClass = mammalClass,
                        Description = "The African Elephant is the largest land animal on Earth, known for its large ears and tusks. It inhabits savannas, forests, and deserts across sub-Saharan Africa.",
                        Diet = "Herbivore, feeding on grasses, fruits, bark, and leaves.",
                        Colors = new List<string> { "Gray" },
                        Weight = 6000,
                        NativeLocation = "Sub-Saharan Africa, including savannas, forests, and deserts",
                        Facts = new List<string>
                        {
                            "African Elephants have the largest brains of any land mammal, weighing around 5 kg.",
                            "They play a crucial role in their ecosystems by dispersing seeds and modifying the landscape.",
                            "African Elephants are listed as vulnerable due to poaching for ivory and habitat loss."
                        }
                    },
                    new Animal
                    {
                        Name = "Elephant, Asian",
                        AnimalClass = mammalClass,
                        Description = "The Asian Elephant is slightly smaller than its African counterpart, with smaller ears and a more rounded back. It is found across Southeast Asia and parts of South Asia.",
                        Diet = "Herbivore, feeding on grasses, fruits, bark, and leaves.",
                        Colors = new List<string> { "Gray" },
                        Weight = 5000,
                        NativeLocation = "Southeast Asia, including India, Sri Lanka, and Southeast Asian countries",
                        Facts = new List<string>
                        {
                            "Asian Elephants are critically endangered, with only around 50,000 individuals remaining in the wild.",
                            "They have a strong social structure, with herds led by the oldest female.",
                            "Asian Elephants are used in various cultural ceremonies and in some parts of the world for logging and tourism."
                        }
                    },
                    new Animal
                    {
                        Name = "Emu",
                        AnimalClass = birdClass,
                        Description = "The Emu is a large, flightless bird native to Australia. It is the second-largest living bird by height, after the ostrich, and is known for its fast running ability.",
                        Diet = "Omnivore, feeding on plants, seeds, fruits, insects, and small animals.",
                        Colors = new List<string> { "Brown", "Gray" },
                        Weight = 45,
                        NativeLocation = "Australia",
                        Facts = new List<string>
                        {
                            "Emus can run at speeds of up to 50 km/h (31 mph), making them one of the fastest birds on land.",
                            "They have three toes on each foot and long, muscular legs that help them maintain high speeds.",
                            "Emus play an important ecological role in their habitat by dispersing seeds and controlling insect populations."
                        }
                    },
                    new Animal
                    {
                        Name = "Ferret, Black-footed",
                        AnimalClass = mammalClass,
                        Description = "The Black-footed Ferret is a small carnivorous mammal native to the grasslands of North America. It is known for its playful and curious nature.",
                        Diet = "Carnivore, primarily feeds on prairie dogs, their eggs, and small rodents.",
                        Colors = new List<string> { "Tan", "Black" },
                        Weight = 1,
                        NativeLocation = "North American grasslands, especially in the Great Plains",
                        Facts = new List<string>
                        {
                            "The Black-footed Ferret is considered one of the most endangered mammals in North America, with conservation efforts focused on increasing their numbers.",
                            "They are nocturnal and spend much of their time hunting and burrowing.",
                            "Black-footed Ferrets rely heavily on prairie dog towns for shelter and food."
                        }
                    },
                    new Animal
                    {
                        Name = "Ferret, Domestic",
                        AnimalClass = mammalClass,
                        Description = "The Domestic Ferret is a small domesticated carnivorous mammal. They are playful and curious, often kept as pets for their energetic and affectionate nature.",
                        Diet = "Carnivore, typically fed commercial ferret food, but they can also eat small portions of meat, eggs, and vegetables.",
                        Colors = new List<string> { "White", "Black", "Brown", "Sable", "Silver" },
                        Weight = 2,
                        NativeLocation = "Domesticated, originally from Europe and Asia",
                        Facts = new List<string>
                        {
                            "Domestic ferrets are highly social and need interaction with their owners or other ferrets to stay mentally healthy.",
                            "Ferrets sleep for about 18 hours a day and are most active during dawn and dusk.",
                            "Ferrets are known for their ability to squeeze into tight spaces, which can sometimes lead to mischief."
                        }
                    },
                    new Animal
                    {
                        Name = "Flamingo, Chilean",
                        AnimalClass = birdClass,
                        Description = "The Chilean Flamingo is a species of flamingo native to South America. It is recognized by its pink plumage and distinctive long legs, commonly found in wetlands and lagoons.",
                        Diet = "Omnivore, feeding on algae, crustaceans, and small insects, which give them their characteristic pink color.",
                        Colors = new List<string> { "Pink", "White" },
                        Weight = 3.5,
                        NativeLocation = "South America, primarily in Chile, Argentina, and Peru",
                        Facts = new List<string>
                        {
                            "Chilean flamingos are capable of walking in shallow waters, using their long legs to stir up the mud and find food.",
                            "They have a specialized feeding technique called 'filter feeding,' where they use their beaks to separate food from water.",
                            "Chilean flamingos are known for their social behavior and often form large flocks in their native habitats."
                        }
                    },
                    new Animal
                    {
                        Name = "Frog, Poison Dart",
                        AnimalClass = amphibianClass,
                        Description = "Poison Dart Frogs are small, brightly colored amphibians native to Central and South America. They are famous for their potent toxins, which they use as a defense mechanism.",
                        Diet = "Carnivorous, feeding on small insects, ants, termites, and spiders.",
                        Colors = new List<string> { "Bright yellow", "Blue", "Green", "Red", "Orange" },
                        Weight = 0.02,
                        NativeLocation = "Central and South America, primarily in rainforests of Panama, Colombia, and Ecuador",
                        Facts = new List<string>
                        {
                            "Poison Dart Frogs get their toxins from the insects they consume in their natural habitat.",
                            "The bright colors of these frogs serve as a warning to predators about their toxicity.",
                            "Despite their small size, their toxins can be deadly if ingested or touched."
                        }
                    },
                    new Animal
                    {
                        Name = "Frog, White's Tree",
                        AnimalClass = amphibianClass,
                        Description = "White's Tree Frog is a large, arboreal species of frog found in Australia. Known for their calm demeanor and large size, they are popular in the pet trade.",
                        Diet = "Omnivorous, feeding on insects, spiders, and small reptiles. They will also eat fruit and vegetation.",
                        Colors = new List<string> { "Green", "Blue", "White" },
                        Weight = 0.5,
                        NativeLocation = "Australia, primarily in the rainforests of Northern Queensland",
                        Facts = new List<string>
                        {
                            "White's Tree Frog is known for its ability to survive long periods of dehydration by entering a state of dormancy.",
                            "Despite their large size, they are excellent climbers and are often found on tree branches.",
                            "They have a long lifespan, with some individuals living over 10 years in captivity."
                        }
                    },
                    new Animal
                    {
                        Name = "Gila Monster",
                        AnimalClass = reptileClass,
                        Description = "The Gila Monster is one of only two venomous lizards in North America, known for its distinctive pink or orange patterns on its black skin.",
                        Diet = "Carnivorous, feeding on small mammals, birds, and eggs.",
                        Colors = new List<string> { "Black", "Pink", "Orange" },
                        Weight = 0.75,
                        NativeLocation = "Southwestern United States, primarily in Arizona and parts of Mexico",
                        Facts = new List<string>
                        {
                            "Gila Monsters are slow-moving and spend much of their time in burrows to avoid extreme heat.",
                            "They have a venomous bite, but they are not aggressive towards humans unless provoked.",
                            "This species is an important part of the desert ecosystem, helping to control populations of small mammals and reptiles."
                        }
                    },
                    new Animal
                    {
                        Name = "Giraffe Masai",
                        AnimalClass = mammalClass,
                        Description = "The Masai Giraffe is a subspecies of giraffe native to central and southern Kenya and Tanzania. It is known for its jagged, irregular spots.",
                        Diet = "Herbivore, feeding primarily on leaves, flowers, and fruits from trees such as acacias.",
                        Colors = new List<string> { "Light brown", "White", "Dark brown" },
                        Weight = 800,
                        NativeLocation = "Kenya and Tanzania",
                        Facts = new List<string>
                        {
                            "Masai Giraffes have a more irregular and jagged pattern of spots compared to other giraffe subspecies.",
                            "They can grow up to 18 feet tall, making them the tallest land mammals.",
                            "These giraffes have long necks that allow them to reach high branches to feed on leaves other herbivores cannot access."
                        }
                    },
                    new Animal
                    {
                        Name = "Goose, Cape Barren",
                        AnimalClass = birdClass,
                        Description = "The Cape Barren Goose is a large, white and gray goose found on the southern coast of Australia, primarily on islands off the coast of South Australia and Tasmania.",
                        Diet = "Herbivore, feeding mainly on grasses, leaves, and roots.",
                        Colors = new List<string> { "White", "Gray", "Black" },
                        Weight = 4,
                        NativeLocation = "South Australia, Tasmania",
                        Facts = new List<string>
                        {
                            "Cape Barren Geese are known for their distinctive greenish-gray plumage and a black stripe running through their beak.",
                            "They are one of the few goose species to breed in Australia and have a low reproductive rate.",
                            "These geese are typically found in open grasslands or coastal areas."
                        }
                    },
                    new Animal
                    {
                        Name = "Gorilla, Western Lowland",
                        AnimalClass = mammalClass,
                        Description = "The Western Lowland Gorilla is a subspecies of gorilla found in the rainforests of central and West Africa. They are the most common gorilla species in zoos around the world.",
                        Diet = "Omnivore, primarily eats fruits, leaves, stems, and occasionally small insects.",
                        Colors = new List<string> { "Dark Brown", "Black" },
                        Weight = 160,
                        NativeLocation = "Central and West Africa",
                        Facts = new List<string>
                        {
                            "Western Lowland Gorillas are critically endangered due to poaching, habitat loss, and disease.",
                            "They are known for their social structure, living in groups led by a dominant silverback male.",
                            "These gorillas are intelligent, with the ability to use tools and communicate using sign language in some cases."
                        }
                    },
                    new Animal
                    {
                        Name = "Hedgehog, African Pygmy",
                        AnimalClass = mammalClass,
                        Description = "The African Pygmy Hedgehog is a small, nocturnal mammal native to parts of North Africa. It is known for its spiny coat and its ability to roll into a ball when threatened.",
                        Diet = "Insectivore, primarily feeds on insects, snails, and small invertebrates.",
                        Colors = new List<string> { "Brown", "White", "Black" },
                        Weight = 0.5,
                        NativeLocation = "North Africa",
                        Facts = new List<string>
                        {
                            "African Pygmy Hedgehogs are commonly kept as pets due to their small size and unique appearance.",
                            "They have a strong sense of smell and can detect food from a distance.",
                            "In the wild, they are solitary creatures, often foraging alone at night."
                        }
                    },
                    new Animal
                    {
                        Name = "Hellbender",
                        AnimalClass = amphibianClass,
                        Description = "The Hellbender is a large, aquatic salamander native to the rivers and streams of North America. It is known for its wrinkled skin and can grow up to 29 inches in length.",
                        Diet = "Carnivore, primarily feeds on aquatic invertebrates, such as crayfish and worms.",
                        Colors = new List<string> { "Brown", "Gray", "Olive" },
                        Weight = 1.8,
                        NativeLocation = "Eastern United States, primarily in clean, fast-flowing streams and rivers.",
                        Facts = new List<string>
                        {
                            "Hellbenders are considered an indicator species, meaning their health reflects the water quality of their habitat.",
                            "They have poor eyesight and rely heavily on their sense of smell and touch to navigate and find food.",
                            "Hellbenders are currently listed as a vulnerable species due to habitat loss and pollution."
                        }
                    },
                    new Animal
                    {
                        Name = "Hippopotamus, Pygmy",
                        AnimalClass = mammalClass,
                        Description = "The Pygmy Hippopotamus is a smaller relative of the common hippopotamus, native to the forests and swamps of West Africa. It is more solitary and elusive than its larger cousin.",
                        Diet = "Herbivore, primarily feeds on grasses, leaves, and fruits.",
                        Colors = new List<string> { "Dark gray", "Olive" },
                        Weight = 275,
                        NativeLocation = "West Africa, primarily in Liberia, Guinea, and Sierra Leone.",
                        Facts = new List<string>
                        {
                            "The Pygmy Hippopotamus is considered endangered due to habitat destruction and poaching.",
                            "Unlike common hippos, pygmy hippos are more adapted to a forested, land-based habitat and are rarely seen in the water.",
                            "They are nocturnal and spend much of their time foraging for food at night."
                        }
                    },
                    new Animal {
                        Name = "Hissing Cockroach",
                        AnimalClass = insectClass,
                        Description = "The Hissing Cockroach is a large species of cockroach native to Madagascar, known for its distinctive hissing sound.",
                        Diet = "Omnivore, feeds on decaying organic matter, including leaves and wood.",
                        Colors = new List<string> { "Brown", "Black" },
                        Weight = 0.03,
                        NativeLocation = "Madagascar",
                        Facts = new List<string>
                        {
                            "Hissing Cockroaches can live up to 5 years in captivity.",
                            "They produce a hissing sound by forcing air through tiny openings on their abdomen."
                        }
                    },
                    new Animal {
                        Name = "Hooded Pitta",
                        AnimalClass = birdClass,
                        Description = "The Hooded Pitta is a vibrant bird species found in Southeast Asia, characterized by its striking plumage and distinctive call.",
                        Diet = "Omnivore, primarily feeds on insects, small invertebrates, and fruits.",
                        Colors = new List<string> { "Green", "Red", "Black", "Blue" },
                        Weight = 0.1,
                        NativeLocation = "Southeast Asia, including Malaysia and Indonesia",
                        Facts = new List<string>
                        {
                            "Hooded Pittas are known for their secretive nature and are often found in dense forest undergrowth.",
                            "They are capable of hopping and running swiftly through the forest floor while foraging."
                        }
                    },
                    new Animal {
                        Name = "Inca Tern",
                        AnimalClass = birdClass,
                        Description = "The Inca Tern is a unique seabird known for its striking appearance, including its white mustache-like feathers and dark plumage.",
                        Diet = "Carnivore, primarily feeds on fish, squid, and other marine invertebrates.",
                        Colors = new List<string> { "Dark gray", "White", "Black" },
                        Weight = 0.25,
                        NativeLocation = "Coastal regions of Peru and Chile in South America",
                        Facts = new List<string>
                        {
                            "Inca Terns are highly social birds, often seen in large colonies along rocky cliffs and beaches.",
                            "Their distinct mustache-like feathers are a unique feature among seabirds."
                        }
                    },
                    new Animal {
                        Name = "Koala",
                        AnimalClass = mammalClass,
                        Description = "The Koala is a marsupial native to Australia, known for its round, fluffy ears and a nose resembling a human thumb.",
                        Diet = "Herbivore, primarily feeds on eucalyptus leaves.",
                        Colors = new List<string> { "Gray", "White" },
                        Weight = 14,
                        NativeLocation = "Eastern and Southeastern Australia",
                        Facts = new List<string>
                        {
                            "Koalas spend most of their time sleeping in eucalyptus trees, where they can sleep up to 18 hours a day.",
                            "Their specialized diet consists almost entirely of eucalyptus leaves, which are toxic to most animals."
                        }
                    },
                    new Animal {
                        Name = "Komodo Dragon",
                        AnimalClass = reptileClass,
                        Description = "The Komodo Dragon is the largest living species of lizard, known for its powerful build and venomous bite.",
                        Diet = "Carnivore, primarily preys on large mammals, birds, and other reptiles.",
                        Colors = new List<string> { "Gray", "Brown", "Green" },
                        Weight = 70,
                        NativeLocation = "Komodo Island, Indonesia",
                        Facts = new List<string>
                        {
                            "Komodo Dragons can reach speeds of up to 20 km/h in short bursts.",
                            "Their saliva contains deadly bacteria and venom, which helps them subdue their prey."
                        }
                    },
                    new Animal {
                        Name = "Leithrix, Red-billed",
                        AnimalClass = birdClass,
                        Description = "The Red-billed Leithrix is a small bird native to the Himalayan region, known for its bright red beak and striking plumage.",
                        Diet = "Omnivore, feeding on seeds, fruits, insects, and small invertebrates.",
                        Colors = new List<string> { "Yellow", "Green", "Red" },
                        Weight = 0.05,
                        NativeLocation = "Himalayan foothills of China, India, Nepal, and Bhutan",
                        Facts = new List<string>
                        {
                            "The Red-billed Leithrix is known for its distinctive chirping calls.",
                            "This species is often seen in mixed-species flocks with other small birds."
                        }
                    },
                    new Animal {
                        Name = "Lemur, Ring-Tailed",
                        AnimalClass = mammalClass,
                        Description = "The Ring-tailed Lemur is a primate found in the wild only on the island of Madagascar, famous for its long, bushy tail with distinctive black and white rings.",
                        Diet = "Omnivore, feeding on fruits, leaves, and small insects.",
                        Colors = new List<string> { "Gray", "White", "Black" },
                        Weight = 2.5,
                        NativeLocation = "Madagascar",
                        Facts = new List<string>
                        {
                            "Ring-tailed lemurs live in social groups called troops, led by a dominant female.",
                            "They are highly active during the day, engaging in various behaviors like sunbathing and grooming."
                        }
                    },
                    new Animal {
                        Name = "Lion, African",
                        AnimalClass = mammalClass,
                        Description = "The African Lion is a large wild cat native to sub-Saharan Africa, known for its majestic mane and social pride structure.",
                        Diet = "Carnivore, primarily hunting large herbivores like wildebeests and zebras.",
                        Colors = new List<string> { "Golden", "Tan" },
                        Weight = 190,
                        NativeLocation = "Sub-Saharan Africa",
                        Facts = new List<string>
                        {
                            "Lions live in prides, which consist of related females, their cubs, and a few males.",
                            "The lion's roar can be heard up to 5 miles away, and it helps to communicate with other pride members."
                        }
                    },
                    new Animal {
                        Name = "Lizard, Philippine Sailfin",
                        AnimalClass = reptileClass,
                        Description = "The Philippine Sailfin Lizard is known for its striking sail-like fin on its back, found in the tropical forests of the Philippines.",
                        Diet = "Omnivore, eating a variety of insects, fruits, and small plants.",
                        Colors = new List<string> { "Green", "Brown", "Black" },
                        Weight = 1,
                        NativeLocation = "Philippines",
                        Facts = new List<string>
                        {
                            "This lizard is an excellent swimmer, and it can dive into water to escape predators.",
                            "It is named for the large sail-like structure along its back, created by elongated spines."
                        }
                    },
                    new Animal {
                    Name = "Lorikeet, Rainbow",
                    AnimalClass = birdClass,
                    Description = "The Rainbow Lorikeet is a small, colorful parrot species found in Australia and surrounding islands, known for its vibrant plumage.",
                    Diet = "Omnivore, primarily feeding on nectar, fruits, and seeds.",
                    Colors = new List<string> { "Red", "Blue", "Green", "Yellow" },
                    Weight = 0.1,
                    NativeLocation = "Australia, Papua New Guinea, surrounding islands",
                    Facts = new List<string>
                    {
                        "Rainbow Lorikeets are known for their playful nature and loud calls.",
                        "They are highly social birds, often found in large flocks."
                    }
},
                    new Animal {
                        Name = "Lynx, Canada",
                        AnimalClass = mammalClass,
                        Description = "The Canada Lynx is a wild cat native to the forests of Canada and parts of Alaska, distinguished by its tufted ears and large paws.",
                        Diet = "Carnivore, preying on small to medium-sized mammals such as hares, rodents, and birds.",
                        Colors = new List<string> { "Gray", "Brown", "White" },
                        Weight = 8,
                        NativeLocation = "Canada, Alaska, Northern United States",
                        Facts = new List<string>
                        {
                            "The Canada Lynx has large, furry paws that help it walk on snow.",
                            "It relies heavily on snowshoe hares for food and can live in harsh winter environments."
                        }
                    },
                    new Animal {
                        Name = "Macaw, Hyacinth",
                        AnimalClass = birdClass,
                        Description = "The Hyacinth Macaw is the largest species of parrot, native to Brazil and notable for its striking cobalt-blue feathers and large, powerful beak.",
                        Diet = "Omnivore, primarily feeding on nuts, seeds, fruits, and some vegetation.",
                        Colors = new List<string> { "Blue", "Yellow" },
                        Weight = 1.7,
                        NativeLocation = "Brazil, Bolivia",
                        Facts = new List<string>
                        {
                            "Hyacinth Macaws have a powerful beak capable of cracking open hard nuts like palm nuts.",
                            "They are critically endangered due to habitat loss and illegal trapping for the pet trade."
                        }
                    },
                    new Animal {
                        Name = "Meerkat",
                        AnimalClass = mammalClass,
                        Description = "The Meerkat is a small mongoose species native to southern Africa, known for its upright posture and social structure.",
                        Diet = "Omnivore, eating insects, small vertebrates, and plant material.",
                        Colors = new List<string> { "Gray", "Tan", "Brown" },
                        Weight = 0.6,
                        NativeLocation = "Southern Africa, including Botswana, Namibia, and South Africa",
                        Facts = new List<string>
                        {
                            "Meerkats live in large social groups, where they work together to find food and protect one another from predators.",
                            "They are known for standing on their hind legs to keep a lookout for danger while the others forage."
                        }
                    },
                    new Animal {
                        Name = "Millipedes",
                        AnimalClass = insectClass,
                        Description = "Millipedes are arthropods known for their many legs, typically around 400-4000 depending on the species.",
                        Diet = "Detritivore, primarily feeding on decaying plant matter.",
                        Colors = new List<string> { "Black", "Brown", "Red" },
                        Weight = 0.05,
                        NativeLocation = "Found in a wide range of environments, primarily in damp forests and grasslands around the world.",
                        Facts = new List<string>
                        {
                            "Millipedes are not insects but are classified as myriapods, a group that also includes centipedes.",
                            "Despite having many legs, they are slow-moving creatures and use their numerous legs to move through leaf litter and soil."
                        }
                    },
                    new Animal {
                        Name = "Monkey, Colobus",
                        AnimalClass = mammalClass,
                        Description = "Colobus monkeys are a type of Old World monkey found in forests of Central and East Africa, recognized for their long, flowing tails and distinctive black and white fur.",
                        Diet = "Herbivore, primarily feeding on leaves, fruits, and seeds.",
                        Colors = new List<string> { "Black", "White" },
                        Weight = 9,
                        NativeLocation = "Central and East Africa, mainly in tropical forests and highland areas.",
                        Facts = new List<string>
                        {
                            "Colobus monkeys have a specialized stomach to help digest the tough leaves they eat.",
                            "They are known for their unique method of locomotion, using their long tails and limbs to move through the trees with ease."
                        }
                    },
                    new Animal {
                        Name = "Myna, Bali",
                        AnimalClass = birdClass,
                        Description = "The Bali myna, also known as the Bali starling, is a critically endangered species of bird endemic to Bali, Indonesia, known for its striking white plumage and blue facial skin.",
                        Diet = "Omnivore, feeding on fruits, seeds, insects, and small invertebrates.",
                        Colors = new List<string> { "White", "Blue" },
                        Weight = 0.2,
                        NativeLocation = "Bali, Indonesia, particularly in the island's forests.",
                        Facts = new List<string>
                        {
                            "The Bali myna is one of the rarest birds in the world, with only a small population remaining in the wild.",
                            "Conservation efforts are underway to protect and rehabilitate the species through captive breeding programs."
                        }
                    },
                    new Animal { Name = "Opossum, Virginia" },
                    new Animal { Name = "Orangutan" },
                    new Animal { Name = "Owl, Barn" },
                    new Animal { Name = "Owl, Great Horned" },
                    new Animal { Name = "Panda, Red" },
                    new Animal { Name = "Pelican, Dalmatian" },
                    new Animal { Name = "Penguin, African" },
                    new Animal { Name = "Penguin, Little" },
                    new Animal { Name = "Pigeon, Green-naped Pheasant" },
                    new Animal { Name = "Pigeon, Nicobar" },
                    new Animal { Name = "Pigeon, Pied Imperial" },
                    new Animal { Name = "Pigeon, Victoria Crowned" },
                    new Animal { Name = "Piranha, Black" },
                    new Animal { Name = "Puma" },
                    new Animal { Name = "Python, Ball" },
                    new Animal { Name = "Python, Reticulated" },
                    new Animal { Name = "Rabbit, Domestic" },
                    new Animal { Name = "Rattlesmake, Timber" },
                    new Animal { Name = "Rhinoceros, Southern White" },
                    new Animal { Name = "Sea Lion" },
                    new Animal { Name = "Seal, Gray" },
                    new Animal { Name = "Seal, Harbor" },
                    new Animal { Name = "Siamang" },
                    new Animal { Name = "Snake, Easter Indigo" },
                    new Animal { Name = "Snow Leopard" },
                    new Animal { Name = "Starling, Golden-breasted" },
                    new Animal { Name = "Stork, Oriental" },
                    new Animal { Name = "Stork, White" },
                    new Animal { Name = "Tanager, Blue-gray" },
                    new Animal { Name = "Tapir, Malayan" },
                    new Animal { Name = "Tarantula, New World" },
                    new Animal { Name = "Tawny Frogmouth" },
                    new Animal { Name = "Tiger, Amur" },
                    new Animal { Name = "Tiger, Sumartran" },
                    new Animal { Name = "Tortoise, Aldabra" },
                    new Animal { Name = "Tortoise, Greek" },
                    new Animal { Name = "Toroise, Star" },
                    new Animal { Name = "Toucan, Toco" },
                    new Animal { Name = "Turtle, Razor-Backed Musk" },
                    new Animal { Name = "Vulture, Ruppell's Griffon" },
                    new Animal { Name = "Vulture, Turkey" },
                    new Animal { Name = "Wallaby, Bennett's" },
                    new Animal { Name = "Warthog" },
                    new Animal { Name = "Zebra, Hartmann's Mountain" }
                });
            }
        }


    }


}
