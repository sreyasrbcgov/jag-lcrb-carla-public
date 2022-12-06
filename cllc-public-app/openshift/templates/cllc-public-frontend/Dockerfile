# Get community edition of nodejs v6.x
FROM angular-app:latest as builder

#https://catalog.redhat.com/software/containers/ubi9/nginx-120/61a609f2bfd4a5234d596287?container-tabs=overview
#section 3.2 from the above link
#FROM registry.access.redhat.com/ubi9/nginx-120
# To indicate that the Runtime is based on registry.access.redhat.com/ubi9/nginx-120
FROM nginx-runtime:120


#nginx-runtime:latest
#nginx:1.18-ubi7

# Copy the build artifacts from the 'builder' image
# to the distribution folder on the runtime image.
COPY --from=builder /opt/app-root/src/dist/. /tmp/app/dist/

# Since the runtime image is itself an s2i image we need to
# short circuit the s2i lifecycle.
# The runtime image "loses" its s2i runtime voodoo when it 
# is used in a dockerSrategy, which is why the explicit `CMD` is necessary
CMD  /usr/libexec/s2i/run
