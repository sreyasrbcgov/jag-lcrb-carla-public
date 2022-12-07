# Use the offical nginx (based on debian)
FROM nginx:1.18-ubi7


ENV STI_SCRIPTS_PATH=/usr/libexec/s2i

#RUN apt-get update && apt-get add
USER 0
# Required for HTTP Basic feature
RUN yum update -y && \
    yum install -y openssl ca-certificates && \
    rm -rf /var/lib/apt/lists/*

# Copy our OpenShift s2i scripts over to default location
COPY ./s2i/bin/ /usr/libexec/s2i/

# Expose this variable to OpenShift
LABEL io.openshift.s2i.scripts-url=image:///usr/libexec/s2i

# Copy config from source to container
COPY nginx.conf.template /tmp/

# =================================================================================
# Fix up permissions
# ref: https://torstenwalter.de/openshift/nginx/2017/08/04/nginx-on-openshift.html
# - S2I sripts must be executable
# - Make sure nginx can read and write it's working directories.
# - The container dynamically configures nginx on startup
# - The application artifacts live in /tmp
# ---------------------------------------------------------------------------------
RUN chmod -R g+rwx $STI_SCRIPTS_PATH
RUN mkdir -p /var/cache/nginx/client_temp && \
    mkdir -p /var/cache/nginx/proxy_temp && \
    mkdir -p /var/cache/nginx/scgi_temp && \
    mkdir -p /var/cache/nginx/uwsgi_temp && \
    mkdir -p /var/cache/nginx/fastcgi_temp
RUN chmod g+rw /var/cache/nginx \ 
               /var/run \
               /var/log/nginx \
               /etc/nginx/nginx.conf 

RUN mkdir -p /tmp/app/dist/ \
    && chmod a+rw /tmp

			   
# =================================================================================


# Work-around for issues with S2I builds on Windows
WORKDIR /tmp

# Nginx runs on port 8080 by default
EXPOSE 8080

# Switch to usermode
USER 104