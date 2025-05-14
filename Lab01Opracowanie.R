# =======================================
# Zadanie 1 
# =======================================

N = 10000 # liczba obserwacji
n = 1:N

set.seed(100)

# a) Rozkład dwupunktowy dwumianowy(p = 0.25)
p = 0.25
X = rbinom(N, 1, p)               # Generujemy N obserwacji 0 lub 1, zgodnych z rozkładem Bernoulliego
S = cumsum(X)                     # Obliczamy sumę skumulowaną obserwacji
srednie = S / n                   # Dzielimy każdą sumę przez numer indeksu, uzyskując średnie cząstkowe

par(mfrow = c(2,2))               # Konfigurujemy wyświetlanie 4 wykresów na jednym ekranie
plot(srednie, type = 'l', main = "dwumianowy", xlab = "n", ylab = "Średnia cząstkowa")
abline(h = p, col = 2)            # Dodajemy linię poziomą na wysokości wartości oczekiwanej p

# Wniosek:
# Średnia cząstkowa stabilizuje się wokół wartości oczekiwanej p = 0.25,
# co jest zgodne z prawem wielkich liczb. Oznacza to, że średnia z próby
# jest dobrym estymatorem wartości oczekiwanej rozkładu Bernoulliego.
# Im większa liczba obserwacji, tym mniejsza zmienność średnich cząstkowych.

# b) Rozkład wykładniczy Exp(λ = 1/3)
lambda = 1/3
X = rexp(N, lambda)
S = cumsum(X)
srednie = S / n

plot(srednie, type = 'l', main = "wykładniczy", xlab = "n", ylab = "Średnia cząstkowa")
abline(h = 1/lambda, col = 2)

# Wniosek:
# Średnia z próby dąży do wartości oczekiwanej 1/λ = 3.
# Obserwujemy spadek niestabilności wraz ze wzrostem próby.
# Potwierdza to, że średnia z próby jest trafnym estymatorem wartości oczekiwanej.

# c) Rozkład Cauchy'ego (a=0, d=1)
a = 0
d = 1
X = rcauchy(N, a, d)
S = cumsum(X)
srednie = S / n

plot(srednie, type = 'l', main = "Cauchy", xlab = "n", ylab = "Średnia cząstkowa")

# Wniosek:
# Średnia z próby dla rozkładu Cauchy’ego nie stabilizuje się – wykres jest nieregularny.
# Wynika to z faktu, że rozkład Cauchy’ego NIE POSIADA wartości oczekiwanej.
# W związku z tym prawo wielkich liczb nie działa w standardowy sposób – średnia nie dąży do żadnej konkretnej wartości.
# Średnia z próby NIE jest sensownym estymatorem położenia dla tego rozkładu – może być bardzo niestabilna,
# ponieważ pojedyncze obserwacje mogą być ekstremalnie duże.

# =======================================
# Zadanie 2
# =======================================

# Rozkład normalny N(μ=4, σ=2)
mi = 4
sigma = 2
N = 500 #  liczba obserwacji
n = 1:N

set.seed(150)

X = rnorm(N, mi, sigma)

# Średnie cząstkowe
srednia = cumsum(X) / n

# Mediany cząstkowe
mediany=c()
for(i in 1:N) mediany[i]=median(X[1:i])

# Odchylenia standardowe i rozstępy międzykwartylowe / 1.35
odchylenie_std = D = numeric(N)
for(i in 2:N){
  odchylenie_std[i] = sd(X[1:i])
  D[i] = IQR(X[1:i]) / 1.35
}

# Wykresy
par(mfrow = c(1,2))

# a) Średnia vs mediana
plot(srednia, type='l', xlab='n', ylab='', main="Średnia vs Mediana")
lines(mediany, lty=2, col=4)
abline(h = mi, col = 2)
legend("bottomright", legend = c("średnia", "mediana"), lty = c(1, 2), col = c(1, 4))

# Wniosek:
# Zarówno średnia, jak i mediana z próby stabilizują się wokół wartości oczekiwanej μ = 4.
# Oba estymatory są zgodne, choć mediana jest bardziej odporna na wartości odstające.
# W rozkładzie normalnym, który jest symetryczny i ma skończone momenty, średnia i mediana są równie trafnymi estymatorami położenia.

# b) Odchylenie standardowe vs. IQR/1.35
plot(odchylenie_std, type='l', xlab='n', ylab='', main="Odchylenie vs IQR/1.35")
lines(D, lty=2, col=4)
abline(h = sigma, col = 2)
legend("bottomright", legend = c("Odchylenie", "IQR/1.35"), lty = c(1, 2), col = c(1, 4))

# Wniosek:
# Odchylenie standardowe i IQR/1.35 zbieżnie estymują σ = 2.
# Oba estymatory są trafne w tym przypadku.

# =======================================
# Zadanie 3 – Stabilność estymatorów w Cauchy(20, 1)
# =======================================

# Generujemy próbę z rozkładu Cauchy’ego
a = 20
d = 1

set.seed(100)

X = rcauchy(N, a, d)

# Średnie cząstkowe
srednia = cumsum(X) / n

# Mediany cząstkowe
mediany=c()
for(i in 1:N) mediany[i]=median(X[1:i])

# Odchylenia standardowe i rozstępy ćwiartkowe (IQR/2)
odchylenie_std = D = numeric(N)
for(i in 2:N){
  odchylenie_std[i] = sd(X[1:i])
  D[i] = IQR(X[1:i]) / 2
}

# Wykresy
par(mfrow = c(1,2))

# a) Średnia vs. mediana
plot(srednia, type='l', xlab='n', ylab='', main="Średnia vs Mediana - Cauchy(20,1)")
lines(mediany, lty=2, col=4)
abline(h = a, col = 2)
legend("topright", legend = c("Średnia", "Mediana"), lty = c(1, 2), col = c(1, 4))

# Wniosek:
# Średnia nie stabilizuje się, ponieważ rozkład Cauchy’ego nie posiada wartości oczekiwanej.
# Mediana stabilizuje się w okolicach 20, co wynika z symetrii rozkładu.
# Dla tego typu rozkładów mediana jest zdecydowanie lepszym estymatorem położenia niż średnia.

# b) Odchylenie standardowe vs. rozstęp ćwiartkowy
plot(odchylenie_std, type='l', xlab='n', ylab='', main="Odchylenie vs IQR/2")
lines(D, lty=2, col=4)
abline(h = d, col = 2)
legend("topright", legend = c("Odchylenie", "IQR/2"), lty = c(1, 2), col = c(1, 4))

# Wniosek:
# Odchylenie standardowe jest bardzo niestabilne i nie dąży do ustalonej wartości,
# ponieważ wariancja rozkładu Cauchy’ego jest nieskończona.
# IQR/2 natomiast jest odporny na obserwacje ekstremalne i może być stosowany jako estymator rozproszenia.

# =======================================
# Zadanie 4 – Estymacja parametru λ dla rozkładu wykładniczego
# =======================================

# Dane: czasy pracy 8 bateryjek (w godzinach)
czas = c(483, 705, 2623, 347, 620, 2719, 1035, 421)

# a) Estymator największej wiarygodności (MLE) dla λ: λ̂ = 1 / średnia
(est1 = 1 / mean(czas))

# Alternatywnie za pomocą funkcji fitdistr (MASS)
library(MASS)
(est2 = fitdistr(czas, densfun = "exponential")$est)

# b)
# (i) Estymator wartości oczekiwanej EX = 1 / λ̂
(estEX = 1 / est1)

# (ii) Szacowane P(X < 1000)
pexp(1000, est1)

# Wnioski:
# λ̂ został oszacowany przy użyciu MLE, co daje dobre przybliżenie.
# Wartość oczekiwana EX wynosi około 1119,125 godzin, co sugeruje, że baterie pracują średnio tyle czasu.
# Szansa, że bateria wytrzyma mniej niż 1000 godzin, wynosi około 59%.