FROM nginx:latest
LABEL maintainer='Fabio Marturano'
COPY /public /var/www/public
COPY /docker/config/nginx.conf /etc/nginx/nginx.conf
RUN chmod 755 -R /var/www/public
EXPOSE 8080 443
ENTRYPOINT ["nginx"]
# Parametros extras para o entrypoint
CMD ["-g", "daemon off;"]
