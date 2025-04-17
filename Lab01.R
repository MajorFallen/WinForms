# Zadanie 1

N = 10000
n = 1:N

set.seed(100)

p = 0.25
X = rbinom(N, 1, p)
S = cumsum(X)
srednie = S/n
par(mfrow = c(2,2))
plot(srednie, type='l')
abline(h=p, col=2)

#par(mfrow = c(2,3))
#par(mfcol = c(2,3))
#layout(1)

lambda = 1/3
X = rexp(N, lambda)
S = cumsum(X)
srednie = S/n
plot(srednie, type='l')
abline(h=(1/lambda), col=2)

a = 0
d = 1
X = rcauchy(N,a,d)
S = cumsum(X)
srednie = S/n
plot(srednie, type='l')

# Zadanie 2

mi=4; sigma=2
N=500; n=1:N
X=rnorm(N,mi,sigma)
srednia=cumsum(X)/n
mediany=c()
for(i in 1:N) mediany[i]=median(X[1:i])

# for(i in wektor){
#   instr1
#   instr2
# }

# median(a)
# sd(a) - odchylenie standardowe
# mean(a)
# var(a)
# IQR(a) - roznica miedzy kwantylami?

odchylenie_std=c();D=c()
for(i in 2:N){
  odchylenie_std[i]=sd(X[1:i])
  D[i]=IQR(X[1:i])/1.35
}

par(mfrow = c(2,2))
plot(srednia,type='l',xlab='i',ylab="",las=1)
lines(mediany,lty=2,col=4)
abline(h=mi,col=2)

plot(odchylenie_std,type='l',xlab='i',ylab="",las=1)
lines(D,lty=2,col=4)
abline(h=sigma,col=2)


# Zadanie 3

a=20; d=1
N=500; n=1:N
X=rcauchy(N,a,d)
srednia=cumsum(X)/n
mediany=c()
for(i in 1:N) mediany[i]=median(X[1:i])

odchylenie_std=c();D=c()
for(i in 2:N){
  odchylenie_std[i]=sd(X[1:i])
  D[i]=IQR(X[1:i])/2
}

par(mfrow = c(2,2))
plot(srednia,type='l',xlab='i',ylab="",las=1)
lines(mediany,lty=2,col=4)
abline(h=a,col=2)

plot(odchylenie_std,type='l',xlab='i',ylab="",las=1)
lines(D,lty=2,col=4)
abline(h=d,col=2)


# Zadanie 4

library(MASS)
czas = c(483,705,2623,347,620,2719,1035,421)
(est1=1/mean(czas))
(est2=fitdistr(czas,densfun="exponential")$est)

estEX = 1/est1
pexp(1000,est1)

