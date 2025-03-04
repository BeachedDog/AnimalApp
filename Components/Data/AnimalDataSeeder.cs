using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalApp.Components.Models;

namespace AnimalApp.Components.Data
{
    public static class DataBaseInitializer
    {
        

        public static void Initialize(AnimalAppContext context)
        {
            if (!context.Database.CanConnect())
            {
                context.Database.EnsureCreated();

                SeedClassData(context);
                SeedAnimalData(context);
             }
        }

        public static void SeedClassData(AnimalAppContext context)
        {
            if (!context.AnimalClasses.Any())
            {
                context.AnimalClasses.AddRange(new List<AnimalClass>
        {
            new AnimalClass { Name = "Mammal", IsWarmBlooded = true, MethodOfReproduction = "Live Birth" },
            new AnimalClass { Name = "Bird", IsWarmBlooded = true, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Reptile", IsWarmBlooded = false, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Amphibian", IsWarmBlooded = false, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Insect", IsWarmBlooded = false, MethodOfReproduction = "Egg" },
            new AnimalClass { Name = "Fish", IsWarmBlooded = false, MethodOfReproduction = "Egg" }
        });

                context.SaveChanges(); // Persist changes to database
            }
        }

        public static void SeedAnimalData(AnimalAppContext context)
        {
            var mammalClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Mammal");
            var birdClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Bird");
            var reptileClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Reptile");
            var amphibianClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Amphibian");
            var insectClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Insect");
            var fishClass = context.AnimalClasses.FirstOrDefault(c => c.Name == "Fish");

            if (!context.Animals.Any())
            {
                context.Animals.AddRange(new List<Animal>
                {
                    new Animal {
                        Id = 1,
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
                        Id = 2,
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
                        Id = 3,
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
                        Id = 4,
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
                        Id = 5,
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
                        Id = 6,
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
                        Id = 7,
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
                        Id = 8,
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
                        Id = 9,
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
                        Id = 10,
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
                        Id = 11,
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
                        Id = 12,
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
                        Id = 13,
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
                        Id = 15,
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
                        Id = 16,
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
                        Id = 17,
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
                        Id = 18,
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
                        Id = 19,
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
                        Id = 20,
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
                        Id = 21,
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
                        Id = 22,
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
                        Id = 23,
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
                        Id = 24,
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
                        Id = 25,
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
                        Id = 26,
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
                        Id = 27,
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
                        Id = 28,
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
                        Id = 29,
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
                        Id = 30,
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
                        Id = 31,
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
                        Id = 32,
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
                        Id = 33,
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
                        Id = 34,
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
                        Id = 35,
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
                        Id = 36,
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
                        Id = 37,
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
                        Id = 38,
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
                        Id = 39,
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
                        Id = 40,
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
                        Id = 41,
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
                        Id = 42,
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
                    new Animal 
                    {
                        Id = 43,
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
                    new Animal 
                    {
                        Id = 44,
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
                    new Animal 
                    {
                        Id = 45,
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
                    new Animal 
                    {
                        Id = 46,
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
                    new Animal 
                    {
                        Id = 47,
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
                    new Animal 
                    {
                        Id = 48,
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
                    new Animal
                    {
                        Id = 49,
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
                    new Animal 
                    {
                        Id = 50,
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
                    new Animal 
                    {
                        Id = 51,
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
                    new Animal 
                    {
                        Id = 52,
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
                    new Animal 
                    {
                        Id = 53,
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
                    new Animal
                    {
                        Id = 54,
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
                    new Animal 
                    {
                        Id = 55,
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
                    new Animal 
                    {
                        Id = 56,
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
                    new Animal 
                    {
                        Id = 57,
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
                    new Animal
                    {
                        Id = 58,
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
                    new Animal
                    {
                        Id = 59,
                        Name = "Opossum, Virginia",
                        AnimalClass = mammalClass,
                        Description = "The Virginia opossum is North America's only marsupial, known for its ability to play dead as a defense mechanism.",
                        Diet = "Omnivore, feeding on fruits, insects, small animals, and carrion.",
                        Colors = new List<string> { "Gray", "White", "Black" },
                        Weight = 2.5,
                        NativeLocation = "North America, found in forests, wetlands, and urban areas.",
                        Facts = new List<string>
                        {
                            "Virginia opossums have a prehensile tail that helps them climb trees.",
                            "They have a high immunity to snake venom and rarely contract rabies due to a lower body temperature."
                        }
                    },
                    new Animal
                    {
                        Id = 60,
                        Name = "Orangutan",
                        AnimalClass = mammalClass,
                        Description = "Orangutans are large, tree-dwelling great apes native to the rainforests of Borneo and Sumatra, known for their intelligence and long, powerful arms.",
                        Diet = "Omnivore, primarily feeding on fruits, leaves, bark, and occasionally insects and bird eggs.",
                        Colors = new List<string> { "Reddish-orange", "Brown" },
                        Weight = 75,
                        NativeLocation = "Rainforests of Borneo and Sumatra in Southeast Asia.",
                        Facts = new List<string>
                        {
                            "Orangutans share about 97% of their DNA with humans and are highly intelligent, using tools to obtain food.",
                            "They are critically endangered due to habitat destruction, poaching, and the illegal pet trade."
                        }
                    },
                    new Animal
                    {
                        Id = 61,
                        Name = "Owl, Barn",
                        AnimalClass = birdClass,
                        Description = "The barn owl is a nocturnal bird of prey known for its heart-shaped face, silent flight, and exceptional hunting skills.",
                        Diet = "Carnivore, primarily feeding on small mammals such as mice, voles, and shrews.",
                        Colors = new List<string> { "White", "Golden-brown", "Gray" },
                        Weight = 0.5,
                        NativeLocation = "Found worldwide, including North and South America, Europe, Africa, Asia, and Australia.",
                        Facts = new List<string>
                        {
                            "Barn owls have incredible hearing, allowing them to locate prey even in complete darkness.",
                            "They are one of the most widely distributed owl species in the world."
                        }
                    },
                    new Animal
                    {
                        Id = 62,
                        Name = "Owl, Great Horned",
                        AnimalClass = birdClass,
                        Description = "The great horned owl is a powerful and adaptable bird of prey known for its distinctive ear tufts and deep hooting call.",
                        Diet = "Carnivore, feeding on a wide range of prey including mammals, birds, reptiles, and amphibians.",
                        Colors = new List<string> { "Brown", "Gray", "White", "Black" },
                        Weight = 1.4,
                        NativeLocation = "Found throughout North and South America in a variety of habitats including forests, deserts, and urban areas.",
                        Facts = new List<string>
                        {
                            "Great horned owls have a powerful grip, capable of exerting 300 pounds of pressure per square inch.",
                            "They are known for their ability to take down prey larger than themselves, including other raptors."
                        }
                    },
                    new Animal
                    {
                        Id = 63,
                        Name = "Panda, Red",
                        AnimalClass = mammalClass,
                        Description = "The red panda is a small arboreal mammal native to the Eastern Himalayas and southwestern China, known for its reddish-brown fur and bushy tail.",
                        Diet = "Omnivore, primarily feeding on bamboo, fruits, berries, and small mammals.",
                        Colors = new List<string> { "Reddish-brown", "Black", "White" },
                        Weight = 6.2,
                        NativeLocation = "Eastern Himalayas and southwestern China, in temperate forests with dense bamboo growth.",
                        Facts = new List<string>
                        {
                            "Red pandas use their long, bushy tails for balance and warmth in cold environments.",
                            "Despite their name, red pandas are not closely related to giant pandas and belong to their own unique family, Ailuridae."
                        }
                    },
                    new Animal
                    {
                        Id = 64,
                        Name = "Pelican, Dalmatian",
                        AnimalClass = birdClass,
                        Description = "The Dalmatian pelican is one of the largest freshwater birds, known for its massive size, large bill, and distinctive white plumage with a curly nape.",
                        Diet = "Carnivore, primarily feeding on fish.",
                        Colors = new List<string> { "White", "Gray", "Orange (bill)" },
                        Weight = 11.5,
                        NativeLocation = "Southeastern Europe, Central Asia, and South Asia, typically found in wetlands, lakes, and rivers.",
                        Facts = new List<string>
                        {
                            "Dalmatian pelicans are among the heaviest flying birds, with a wingspan reaching up to 3.5 meters (11.5 feet).",
                            "They use coordinated group fishing techniques to herd fish into shallow waters for easier capture."
                        }
                    },
                    new Animal
                    {
                        Id = 65,
                        Name = "Penguin, African",
                        AnimalClass = birdClass,
                        Description = "The African penguin, also known as the jackass penguin, is a species of flightless bird native to the southern coast of Africa, recognized for its distinctive black-and-white plumage and braying call.",
                        Diet = "Carnivore, primarily feeding on fish, squid, and crustaceans.",
                        Colors = new List<string> { "Black", "White", "Pink (around eyes)" },
                        Weight = 3.5,
                        NativeLocation = "Coastal regions of South Africa and Namibia, often found on rocky islands and sandy beaches.",
                        Facts = new List<string>
                        {
                            "African penguins are the only penguin species that breed in Africa.",
                            "Their population has declined significantly due to habitat destruction, overfishing, and oil spills, making them an endangered species."
                        }
                    },
                    new Animal
                    {
                        Id = 66,
                        Name = "Penguin, Little",
                        AnimalClass = birdClass,
                        Description = "The little penguin, also known as the fairy penguin, is the smallest species of penguin, recognized for its petite size and distinctive blue feathers.",
                        Diet = "Carnivore, mainly feeding on small fish, krill, and other marine invertebrates.",
                        Colors = new List<string> { "Blue", "White" },
                        Weight = 1.0,
                        NativeLocation = "Coastal regions of southern Australia and New Zealand.",
                        Facts = new List<string>
                        {
                            "Little penguins are the smallest of all penguin species, standing only around 30 cm tall.",
                            "They are known for their nocturnal behavior, often foraging at night and resting during the day."
                        }
                    },
                    new Animal
                    {
                        Id = 67,
                        Name = "Pigeon, Green-naped Pheasant",
                        AnimalClass = birdClass,
                        Description = "The green-naped pheasant pigeon is a species of pigeon found in the tropical rainforests of New Guinea, known for its striking green nape and large size.",
                        Diet = "Omnivore, feeding on seeds, fruits, and small invertebrates.",
                        Colors = new List<string> { "Green", "Blue", "Grey" },
                        Weight = 0.5,
                        NativeLocation = "Tropical forests of New Guinea.",
                        Facts = new List<string>
                        {
                            "Green-naped pheasant pigeons are known for their vibrant plumage, especially the iridescent green feathers on their neck.",
                            "This species is arboreal, spending most of its time in the forest canopy."
                        }
                    },
                    new Animal
                    {
                        Id = 68,
                        Name = "Pigeon, Nicobar",
                        AnimalClass = birdClass,
                        Description = "The Nicobar pigeon is a large, colorful pigeon found on the Nicobar Islands, known for its striking iridescent plumage and long, flowing tail feathers.",
                        Diet = "Omnivore, feeding on seeds, fruits, and leaves.",
                        Colors = new List<string> { "Green", "Blue", "Grey", "Purple" },
                        Weight = 0.4,
                        NativeLocation = "Nicobar Islands in the Indian Ocean.",
                        Facts = new List<string>
                        {
                            "The Nicobar pigeon is closely related to the extinct dodo, with similar features.",
                            "It has a unique call that sounds like a low whistle and is often heard in the dense forests it inhabits."
                        }
                    },
                    new Animal
                    {
                        Id = 69,
                        Name = "Pigeon, Pied Imperial",
                        AnimalClass = birdClass,
                        Description = "The Pied Imperial pigeon is a large, striking pigeon with a white body and contrasting black wings, native to the tropical forests of the Philippines.",
                        Diet = "Primarily frugivorous, feeding on a variety of fruits and seeds.",
                        Colors = new List<string> { "White", "Black" },
                        Weight = 0.5,
                        NativeLocation = "Philippine Islands, particularly in dense forested areas.",
                        Facts = new List<string>
                        {
                            "The Pied Imperial pigeon is known for its large size and distinctive pied coloring.",
                            "It is threatened by habitat loss and hunting, with conservation efforts focusing on protecting its natural habitat."
                        }
                     },
                    new Animal
                    {
                        Id = 70,
                        Name = "Pigeon, Victoria Crowned",
                        AnimalClass = birdClass,
                        Description = "The Victoria crowned pigeon is a large, striking pigeon with a distinctive blue crown and elaborate feathers, native to New Guinea.",
                        Diet = "Primarily frugivorous, feeding on fruits, seeds, and occasionally invertebrates.",
                        Colors = new List<string> { "Blue", "White", "Black" },
                        Weight = 1.2,
                        NativeLocation = "New Guinea, particularly in lowland rainforests.",
                        Facts = new List<string>
                        {
                            "The Victoria crowned pigeon is one of the largest and most beautiful pigeons in the world.",
                            "It is known for its elaborate, lace-like crest of feathers on top of its head."
                        }
                    },
                    new Animal
                    {
                        Id = 71,
                        Name = "Piranha, Black",
                        AnimalClass = fishClass,
                        Description = "The black piranha is a species of piranha known for its powerful bite and distinctive black coloration, native to the rivers of South America.",
                        Diet = "Carnivorous, feeding on fish, invertebrates, and occasionally small mammals and birds.",
                        Colors = new List<string> { "Black", "Gray" },
                        Weight = 1.5,
                        NativeLocation = "Rivers of the Amazon Basin, South America.",
                        Facts = new List<string>
                        {
                            "Black piranhas are among the largest and most aggressive members of the piranha family.",
                            "Despite their fearsome reputation, they typically feed on smaller prey and scavenge."
                        }
                    },
                    new Animal
                    {
                        Id = 72,
                        Name = "Puma",
                        AnimalClass = mammalClass,
                        Description = "The puma, also known as the cougar or mountain lion, is a large cat native to the Americas, known for its agility and stealth.",
                        Diet = "Carnivorous, primarily hunting deer, rabbits, and other small mammals.",
                        Colors = new List<string> { "Tan", "Gray", "Light Brown" },
                        Weight = 60,
                        NativeLocation = "North and South America, from Canada to Argentina.",
                        Facts = new List<string>
                        {
                            "Pumas are solitary animals and are known for their ability to adapt to various environments.",
                            "They have one of the largest ranges of any wild terrestrial mammal in the Americas."
                        }
                    },
                    new Animal
                    {
                        Id = 73,
                        Name = "Python, Ball",
                        AnimalClass = reptileClass,
                        Description = "The ball python, also known as the royal python, is a non-venomous snake native to West and Central Africa, known for its docile nature and unique ability to curl into a tight ball.",
                        Diet = "Carnivorous, primarily feeding on rodents and other small mammals.",
                        Colors = new List<string> { "Black", "Brown", "Yellow" },
                        Weight = 1.5,
                        NativeLocation = "West and Central Africa, including countries such as Ghana, Togo, and Benin.",
                        Facts = new List<string>
                        {
                            "Ball pythons are known for their ability to 'ball up' when threatened, protecting their head inside the coil.",
                            "They are a popular pet due to their calm temperament and manageable size."
                        }
                    },
                    new Animal
                    {
                        Id = 74,
                        Name = "Python, Reticulated",
                        AnimalClass = reptileClass,
                        Description = "The reticulated python is one of the longest and heaviest snake species in the world, known for its intricate and beautiful pattern of scales.",
                        Diet = "Carnivorous, primarily feeding on birds, mammals, and reptiles.",
                        Colors = new List<string> { "Yellow", "Black", "White" },
                        Weight = 160,
                        NativeLocation = "Southeast Asia, including Indonesia, the Philippines, and parts of Malaysia.",
                        Facts = new List<string>
                        {
                            "The reticulated python can grow to lengths of over 30 feet, making it one of the longest snakes in the world.",
                            "Despite their size, they are relatively reclusive and are known to be excellent swimmers."
                        }
                    },
                    new Animal
                    {
                        Id = 75,
                        Name = "Rabbit, Domestic",
                        AnimalClass = mammalClass,
                        Description = "The domestic rabbit is a small mammal commonly kept as a pet, known for its gentle temperament and variety of breeds.",
                        Diet = "Herbivore, feeding primarily on hay, vegetables, and fruits.",
                        Colors = new List<string> { "White", "Brown", "Black", "Grey" },
                        Weight = 2,
                        NativeLocation = "Domesticated worldwide.",
                        Facts = new List<string>
                        {
                            "Rabbits have a strong tendency to dig and burrow, which is an instinctual behavior inherited from wild ancestors.",
                            "They can communicate through body language, such as thumping their hind legs to warn of danger."
                        }
                    },
                    new Animal
                    {
                        Id = 76,
                        Name = "Rattlesnake, Timber",
                        AnimalClass = reptileClass,
                        Description = "The timber rattlesnake is a venomous pit viper found in the eastern United States, known for its distinctive rattle and warning sound.",
                        Diet = "Carnivore, primarily feeding on small mammals, birds, and amphibians.",
                        Colors = new List<string> { "Brown", "Gray", "Yellow", "Black" },
                        Weight = 2.5,
                        NativeLocation = "Eastern United States, particularly in forested areas.",
                        Facts = new List<string>
                        {
                            "Timber rattlesnakes are one of the largest venomous snakes in the U.S.",
                            "They use their rattle as a warning to potential predators or threats."
                        }
                    },
                    new Animal
                    {
                        Id = 77,
                        Name = "Rhinoceros, Southern White",
                        AnimalClass = mammalClass,
                        Description = "The Southern white rhinoceros is one of the largest species of rhino, known for its broad square lips and large size.",
                        Diet = "Herbivore, grazing on grass and other vegetation.",
                        Colors = new List<string> { "Gray", "Light gray" },
                        Weight = 1800,
                        NativeLocation = "Southern Africa, particularly in South Africa, Namibia, Zimbabwe, and Kenya.",
                        Facts = new List<string>
                        {
                            "The Southern white rhino is the most abundant species of rhinoceros in the world.",
                            "Conservation efforts have led to a significant recovery in population from near extinction."
                        }
                    },
                    new Animal
                    {
                        Id = 78,
                        Name = "Sea Lion",
                        AnimalClass = mammalClass,
                        Description = "Sea lions are large marine mammals known for their intelligence and playful nature, often seen in coastal regions.",
                        Diet = "Carnivore, feeding on fish, squid, and other marine animals.",
                        Colors = new List<string> { "Brown", "Dark brown" },
                        Weight = 300,
                        NativeLocation = "Coastal regions of the Pacific Ocean, primarily along the coasts of North America and South America.",
                        Facts = new List<string>
                        {
                            "Sea lions are highly social animals, living in large colonies.",
                            "They are excellent swimmers and can dive to great depths in search of food."
                        }
                    },
                    new Animal
                    {
                        Id = 79,
                        Name = "Seal, Gray",
                        AnimalClass = mammalClass,
                        Description = "The gray seal is a large pinniped species known for its robust build and distinctive coat pattern.",
                        Diet = "Carnivore, primarily feeding on fish, squid, and crustaceans.",
                        Colors = new List<string> { "Gray", "Silver" },
                        Weight = 150,   
                        NativeLocation = "Coastal regions of the North Atlantic Ocean, particularly in the northern parts of Europe and North America.",
                        Facts = new List<string>
                        {
                            "Gray seals are known for their playful behavior and inquisitive nature.",
                            "They are one of the most widespread seal species, found in both European and North American waters."
                        }
                    },
                    new Animal
                    {
                        Id = 80,
                        Name = "Seal, Harbor",
                        AnimalClass = mammalClass,
                        Description = "The harbor seal is a common species of seal found along coastlines in temperate regions. It has a rounded face and a spotted or striped coat.",
                        Diet = "Carnivore, feeding on fish, mollusks, and crustaceans.",
                        Colors = new List<string> { "Gray", "Brown", "Spotted" },
                        Weight = 80,
                        NativeLocation = "Coastal areas of the North Atlantic and North Pacific Oceans, including both Europe and North America.",
                        Facts = new List<string>
                        {
                            "Harbor seals are highly adaptable and can be found in a variety of coastal habitats, from rocky shores to sandy beaches.",
                            "They are often seen hauled out on land or ice floes to rest and sunbathe."
                        }
                    },
                    new Animal
                    {
                        Id = 81,
                        Name = "Siamang",
                        AnimalClass = mammalClass,
                        Description = "The siamang is a large gibbon native to the rainforests of Southeast Asia. It is known for its vocalizations and large throat sac, which it uses to amplify its calls.",
                        Diet = "Omnivore, feeding on fruits, leaves, flowers, and small animals.",
                        Colors = new List<string> { "Black" },
                        Weight = 14,
                        NativeLocation = "Rainforests of Malaysia, Indonesia, and southern Thailand.",
                        Facts = new List<string>
                        {
                            "Siamangs are the largest of the gibbons and are known for their impressive vocal abilities, often singing in duets with their mates.",
                            "They are arboreal, spending most of their time in trees and moving with a method known as brachiation (swinging from branch to branch)."
                        }
                    },
                    new Animal
                    {
                        Id = 82,
                        Name = "Snake, Eastern Indigo",
                        AnimalClass = reptileClass,
                        Description = "The Eastern Indigo snake is a large, non-venomous snake native to the southeastern United States. It is known for its shiny, blue-black coloration and its ability to control populations of small mammals and other reptiles.",
                        Diet = "Carnivore, primarily feeds on small mammals, birds, eggs, and other reptiles.",
                        Colors = new List<string> { "Blue-black", "Shiny" },
                        Weight = 4.5,
                        NativeLocation = "Southeastern United States, including parts of Florida, Georgia, and Alabama.",
                        Facts = new List<string>
                        {
                            "The Eastern Indigo snake is the longest native snake in the United States, capable of reaching lengths up to 2.5 meters.",
                            "This species is protected due to habitat loss and is listed as threatened in some parts of its range."
                        }
                    },
                    new Animal
                    {
                        Id = 83,
                        Name = "Snow Leopard",
                        AnimalClass = mammalClass,
                        Description = "The snow leopard is a large cat native to the mountain ranges of Central and South Asia. It is well adapted to cold, high-altitude environments with its thick fur and long tail.",
                        Diet = "Carnivore, primarily preys on wild sheep, goats, and smaller mammals.",
                        Colors = new List<string> { "Gray", "White", "Black spots" },
                        Weight = 35,
                        NativeLocation = "Mountain ranges of Central and South Asia, including the Himalayas and Tibetan Plateau.",
                        Facts = new List<string>
                        {
                            "Snow leopards are known for their ability to navigate difficult mountainous terrain, aided by their strong limbs and long tail for balance.",
                            "They are elusive and solitary animals, making them difficult to study in the wild."
                        }
                    },
                    new Animal
                    {
                        Id = 84,
                        Name = "Starling, Golden-breasted",
                        AnimalClass = birdClass,
                        Description = "The golden-breasted starling is a vibrant, medium-sized bird native to East Africa, known for its striking golden-yellow plumage and iridescent green wings.",
                        Diet = "Omnivore, feeding on fruits, insects, and seeds.",
                        Colors = new List<string> { "Golden", "Green", "Black" },
                        Weight = 0.1,
                        NativeLocation = "East Africa, particularly in savannahs and woodlands.",
                        Facts = new List<string>
                        {
                            "The golden-breasted starling is known for its beautiful, colorful plumage and social behavior.",
                            "They are often seen in small groups and are highly vocal, emitting a variety of calls."
                        }
                    },
                    new Animal
                    {
                        Id = 85,
                        Name = "Stork, Oriental",
                        AnimalClass = birdClass,
                        Description = "The oriental stork is a large, migratory bird native to Eastern Asia, recognized for its white body, black wings, and long red legs and bill.",
                        Diet = "Carnivore, feeding on fish, amphibians, and small mammals.",
                        Colors = new List<string> { "White", "Black", "Red" },
                        Weight = 4.5,
                        NativeLocation = "Eastern Asia, particularly in China, Korea, and Japan.",
                        Facts = new List<string>
                        {
                            "The oriental stork migrates from its breeding grounds in northeastern Asia to warmer areas in Southeast Asia during the winter.",
                            "It is considered a symbol of good luck and prosperity in some Asian cultures."
                        }
                    },
                    new Animal
                    {
                        Id = 86,
                        Name = "Stork, White",
                        AnimalClass = birdClass,
                        Description = "The white stork is a large bird commonly found in Europe, Asia, and parts of Africa, known for its long legs, long neck, and striking white and black plumage.",
                        Diet = "Carnivore, primarily feeding on insects, frogs, small rodents, and fish.",
                        Colors = new List<string> { "White", "Black" },
                        Weight = 4,
                        NativeLocation = "Europe, Asia, and parts of Africa.",
                        Facts = new List<string>
                        {
                            "The white stork is a migratory species, traveling long distances between Europe and Africa.",
                            "In many cultures, the white stork is associated with bringing babies and good luck."
                        }
                    },
                    new Animal
                    {
                        Id = 87,
                        Name = "Tanager, Blue-gray",
                        AnimalClass = birdClass,
                        Description = "The blue-gray tanager is a small songbird found in Central and South America, known for its striking blue and gray plumage.",
                        Diet = "Omnivore, feeding on fruits, berries, and insects.",
                        Colors = new List<string> { "Blue", "Gray" },
                        Weight = 0.03,
                        NativeLocation = "Central and South America, particularly in the rainforests.",
                        Facts = new List<string>
                        {
                            "Blue-gray tanagers are commonly found in forested areas and are known for their energetic and playful behavior.",
                            "They are often seen in pairs or small groups, hopping among the branches in search of food."
                        }
                    },
                    new Animal
                    {
                        Id = 88,
                        Name = "Tapir, Malayan",
                        AnimalClass = mammalClass,
                        Description = "The Malayan tapir is a large herbivorous mammal native to the Malay Peninsula and parts of Thailand and Sumatra. It is known for its distinct black and white coloration.",
                        Diet = "Herbivore, primarily feeding on leaves, fruits, and other vegetation.",
                        Colors = new List<string> { "Black", "White" },
                        Weight = 300,
                        NativeLocation = "Malay Peninsula, parts of Thailand, and Sumatra.",
                        Facts = new List<string>
                        {
                            "Malayan tapirs are excellent swimmers and often use rivers to travel between areas of dense forest.",
                            "The species is endangered due to habitat loss and poaching."
                        }
                    },
                    new Animal
                    {
                        Id = 89,
                        Name = "Tarantula, New World",
                        AnimalClass = insectClass,
                        Description = "The New World tarantulas are a group of tarantulas found in the Americas, known for their larger size and more docile temperament compared to Old World species. They often have striking color patterns and are popular in the pet trade.",
                        Diet = "Carnivore, feeding primarily on insects, small mammals, and birds.",
                        Colors = new List<string> { "Brown", "Black", "Red" },
                        Weight = 0.05,
                        NativeLocation = "North, Central, and South America.",
                        Facts = new List<string>
                        {
                            "New World tarantulas have urticating hairs on their abdomen, which they can flick to defend themselves.",
                            "Despite their intimidating appearance, they are generally not aggressive towards humans."
                        }
                    },
                    new Animal
                    {
                        Id = 90,
                        Name = "Tawny Frogmouth",
                        AnimalClass = birdClass,
                        Description = "The Tawny Frogmouth is a nocturnal bird native to Australia, known for its wide, frog-like mouth and excellent camouflage. It often remains motionless during the day, blending into tree branches.",
                        Diet = "Carnivore, primarily feeding on insects, small vertebrates, and invertebrates.",
                        Colors = new List<string> { "Gray", "Brown", "White" },
                        Weight = 0.4,
                        NativeLocation = "Australia, particularly in forested and woodland areas.",
                        Facts = new List<string>
                        {
                            "The Tawny Frogmouth is known for its unique hunting technique of silently swooping down on prey during the night.",
                            "Despite their resemblance to owls, Tawny Frogmouths are actually more closely related to nightjars."
                        }
                    },
                    new Animal
                    {
                        Id = 91,
                        Name = "Tiger, Amur",
                        AnimalClass = mammalClass,
                        Description = "The Amur tiger, also known as the Siberian tiger, is the largest wildcat in the world, found primarily in the Russian Far East. It is critically endangered, with only a small number of individuals left in the wild.",
                        Diet = "Carnivore, primarily feeding on large prey such as deer, wild boar, and occasionally smaller animals.",
                        Colors = new List<string> { "Orange", "Black", "White" },
                        Weight = 200,
                        NativeLocation = "Russian Far East, northeastern China.",
                        Facts = new List<string>
                        {
                            "Amur tigers are solitary and territorial, with home ranges that can span hundreds of square kilometers.",
                            "Conservation efforts have helped stabilize the population of Amur tigers, but they remain critically endangered due to poaching and habitat loss."
                        }
                    },
                    new Animal
                    {
                        Id = 92,
                        Name = "Tiger, Sumatran",
                        AnimalClass = mammalClass,
                        Description = "The Sumatran tiger is a critically endangered subspecies of tiger found exclusively on the Indonesian island of Sumatra. It is smaller than other tiger subspecies, but it is still a powerful predator.",
                        Diet = "Carnivore, feeding on deer, wild boar, and other small mammals.",
                        Colors = new List<string> { "Orange", "Black", "White" },
                        Weight = 100,
                        NativeLocation = "Sumatra, Indonesia.",
                        Facts = new List<string>
                        {
                            "Sumatran tigers are solitary animals, and their population is scattered across the dense forests of Sumatra.",
                            "Habitat destruction, poaching, and human-wildlife conflict have led to a dramatic decline in the population of Sumatran tigers."
                        }
                    },
                    new Animal
                    {
                        Id = 93,
                        Name = "Tortoise, Aldabra",
                        AnimalClass = reptileClass,
                        Description = "The Aldabra giant tortoise is one of the largest tortoises in the world, native to the Aldabra Atoll in the Seychelles. They are long-lived creatures and can live over 100 years.",
                        Diet = "Herbivore, primarily feeds on grasses, leaves, and fruits.",
                        Colors = new List<string> { "Gray", "Green" },
                        Weight = 250,
                        NativeLocation = "Aldabra Atoll, Seychelles.",
                        Facts = new List<string>
                        {
                            "Aldabra giant tortoises are known for their immense size and slow movements, with some individuals weighing over 250 kg.",
                            "The species is endangered due to habitat loss and hunting, though conservation efforts are in place to protect them."
                        }
                    },
                    new Animal
                    {
                        Id = 94,
                        Name = "Tortoise, Greek",
                        AnimalClass = reptileClass,
                        Description = "The Greek tortoise is a small, terrestrial tortoise native to parts of southern Europe and the Middle East. It is characterized by its high-domed shell and distinct patterns.",
                        Diet = "Herbivore, primarily feeds on grasses, leaves, and fruits.",
                        Colors = new List<string> { "Yellow", "Brown" },
                        Weight = 1.5,
                        NativeLocation = "Southern Europe, Middle East.",
                        Facts = new List<string>
                        {
                            "Greek tortoises are often kept as pets due to their manageable size and docile nature.",
                            "They are a threatened species in the wild, primarily due to habitat destruction and illegal pet trade."
                        }
                    },
                    new Animal
                    {
                        Id = 95,
                        Name = "Tortoise, Star",
                        AnimalClass = reptileClass,
                        Description = "The star tortoise is a large species of tortoise found in India and Sri Lanka, known for its distinctive star-like patterns on its domed shell.",
                        Diet = "Herbivore, feeds on grasses, fruits, and cactus.",
                        Colors = new List<string> { "Yellow", "Black" },
                        Weight = 5.0,
                        NativeLocation = "India, Sri Lanka.",
                        Facts = new List<string>
                        {
                            "The star patterns on the tortoise's shell are unique to each individual, much like fingerprints in humans.",
                            "Star tortoises are threatened by habitat loss and the pet trade."
                        }
                    },
                    new Animal
                    {
                        Id = 96,
                        Name = "Toucan, Toco",
                        AnimalClass = birdClass,
                        Description = "The toco toucan is a large species of toucan native to South America, recognized for its large, colorful bill and striking black and white plumage.",
                        Diet = "Omnivore, feeds on fruits, insects, and small reptiles.",
                        Colors = new List<string> { "Black", "White", "Orange", "Yellow" },
                        Weight = 0.7,
                        NativeLocation = "South America, primarily in Brazil, Argentina, and Paraguay.",
                        Facts = new List<string>
                        {
                            "The toco toucan's bill, despite its large size, is lightweight due to its hollow structure.",
                            "Toco toucans are social birds, often seen in pairs or small groups."
                        }
                    },
                    new Animal
                    {
                        Id = 97,
                        Name = "Turtle, Razor-Backed Musk",
                        AnimalClass = reptileClass,
                        Description = "The razor-backed musk turtle is a small, freshwater turtle found in North America, known for its distinctively pointed, spiked carapace.",
                        Diet = "Carnivorous, feeding on aquatic invertebrates, small fish, and plants.",
                        Colors = new List<string> { "Brown", "Black", "Yellow" },
                        Weight = 0.5,
                        NativeLocation = "Southern United States, particularly in the Mississippi River Basin.",
                        Facts = new List<string>
                        {
                            "The razor-backed musk turtle is named for the sharp, ridge-like keel on its carapace.",
                            "It has a strong odor, which is why it’s called a musk turtle."
                        }
                    },
                    new Animal
                    {
                        Id = 98,
                        Name = "Vulture, Ruppell's Griffon",
                        AnimalClass = birdClass,
                        Description = "Rüppell's griffon vulture is a large bird of prey found in parts of Africa, known for its impressive wingspan and scavenging habits.",
                        Diet = "Carnivorous, primarily feeding on carcasses of large animals.",
                        Colors = new List<string> { "Brown", "White", "Black" },
                        Weight = 7.5,
                        NativeLocation = "Sub-Saharan Africa, especially in the Sahel region.",
                        Facts = new List<string>
                        {
                            "Rüppell's griffon vulture has the highest known bird flight altitude, having been recorded at over 37,000 feet.",
                            "It plays a vital role in the ecosystem by cleaning up carrion and preventing the spread of disease."
                        }
                    },
                    new Animal
                    {
                        Id = 99,
                        Name = "Vulture, Turkey",
                        AnimalClass = birdClass,
                        Description = "The turkey vulture is a large bird of prey native to the Americas, recognized by its red head and dark plumage. It is a scavenger, feeding primarily on carrion.",
                        Diet = "Carnivorous, feeding primarily on decaying carcasses.",
                        Colors = new List<string> { "Black", "Brown", "Red" },
                        Weight = 2.0,
                        NativeLocation = "North and South America, especially in open fields and forests.",
                        Facts = new List<string>
                        {
                            "Turkey vultures have an incredible sense of smell, which helps them locate food from great distances.",
                            "They have a unique method of cooling down by defecating on their legs, which helps them regulate their body temperature."
                        }
                    },
                    new Animal
                    {
                        Id = 100,
                        Name = "Vulture, Turkey",
                        AnimalClass = birdClass,
                        Description = "The turkey vulture is a large bird of prey native to the Americas, recognized by its red head and dark plumage. It is a scavenger, feeding primarily on carrion.",
                        Diet = "Carnivorous, feeding primarily on decaying carcasses.",
                        Colors = new List<string> { "Black", "Brown", "Red" },
                        Weight = 2.0,
                        NativeLocation = "North and South America, especially in open fields and forests.",
                        Facts = new List<string>
                        {
                            "Turkey vultures have an incredible sense of smell, which helps them locate food from great distances.",
                            "They have a unique method of cooling down by defecating on their legs, which helps them regulate their body temperature."
                        }
                    },
                    new Animal
                    {
                        Id = 101,
                        Name = "Warthog",
                        AnimalClass = mammalClass,
                        Description = "The warthog is a wild member of the pig family native to sub-Saharan Africa. It is known for its tusks and distinctive facial warts.",
                        Diet = "Omnivore, feeding on grass, roots, fruits, and occasionally small animals or carrion.",
                        Colors = new List<string> { "Gray", "Brown" },
                        Weight = 90.0,
                        NativeLocation = "Sub-Saharan Africa, primarily in savannas and grasslands.",
                        Facts = new List<string>
                        {
                            "Warthogs use their tusks to defend themselves against predators and compete for mates.",
                            "Despite their fierce appearance, warthogs are relatively peaceful and often graze in groups."
                        }
                    },
                    new Animal
                    {
                        Id = 102,
                        Name = "Zebra, Hartmann's Mountain",
                        AnimalClass = mammalClass,
                        Description = "Hartmann's mountain zebra is a subspecies of zebra found in the mountainous regions of Namibia and Angola, characterized by narrow stripes and a more rugged body.",
                        Diet = "Herbivore, primarily feeding on grasses, shrubs, and leaves.",
                        Colors = new List<string> { "White", "Black" },
                        Weight = 350.0,
                        NativeLocation = "Mountainous areas of Namibia and Angola.",
                        Facts = new List<string>
                        {
                            "Hartmann's mountain zebra is adapted to the rugged terrain of the mountains and has specialized hooves for climbing.",
                            "The species is considered vulnerable due to habitat loss and hunting."
                        }
                    }
                });
                context.SaveChanges(); // Persist changes to database
            }
        }


    }


}
